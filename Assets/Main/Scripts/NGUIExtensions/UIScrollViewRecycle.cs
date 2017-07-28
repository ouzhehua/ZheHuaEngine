/// <summary>
/// add by ouzhehua
/// ScrollView内Item循环利用控制类
/// </summary>

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(UIScrollView))]
public class UIScrollViewRecycle : MonoBehaviour
{
	public enum Movement
	{
		Horizontal,
		Vertical
	}
	public Movement movement = Movement.Horizontal;
	public UIWidget.Pivot itemPivot = UIWidget.Pivot.TopLeft;
	public bool fillMode = false;
	public int perLineCount = 0;
	public int cellWidth = 200;
	public int cellHeight = 200;
	//item模版
	public UIScrollViewItemBase templateItem;

	//ScrollView
	private UIScrollView mScrollView;
	public UIScrollView scrollView{ get { return mScrollView; } }

	//ScrollView是否在滑动
	private bool mScrollViewMoving = false;
	//item容器，除了用来摆放item，还能提前占用scrollview的滑动区域
	private UIWidget itemContainer;
	//完整显示行列时，最后一个item的索引
	private int completelyIndex;
	//上次显示的所有item中的第一个索引
	private int cacheBaginIndex = -1;
	//缓存item实例
	private List<UIScrollViewItemBase> cacheItems = new List<UIScrollViewItemBase> ();
	//缓存item list 的游标
	private int itemListNonius = 0;

	[SerializeField]
	private int _itemCount = 0;
	//设置显示item的数量
	public int itemCount {
		set {
			_itemCount = Mathf.Max (0, value);

			UpdateItemContainerSize ();
			UpdateItemCacheCount ();
			UpdateItemsData (true);
		}
		get
		{ return _itemCount; }
	}

	public delegate void OnItemInstantiate (UIScrollViewItemBase item);
	public OnItemInstantiate onItemInstantiate;

	void Awake()
	{
		mScrollView = GetComponent<UIScrollView> ();
		if (mScrollView == null) {
			Debug.LogError ("Put UIScrollViewRecycle and UIScrollView together , please !");
			enabled = false;
			return;
		}
		mScrollView.contentPivot = UIWidget.Pivot.TopLeft;
		mScrollView.onDragStarted = new UIScrollView.OnDragNotification (onDragStarted);
		mScrollView.onStoppedMoving = new UIScrollView.OnDragNotification (onStoppedMoving);
		mScrollView.movement = (UIScrollView.Movement)Enum.Parse (typeof(UIScrollView.Movement), movement.ToString ());

		if (perLineCount == 0) {
			CalculatePerLineCount ();
		}

		//check parent's pivot
		UIWidget parentWidget = transform.parent.GetComponent<UIWidget>();
		if (parentWidget != null) {
			if (parentWidget.pivot != UIWidget.Pivot.TopLeft) {
				Debug.LogError ("hey man , set " + parentWidget.name + "'s pivot as TopLeft please");
			}
		} else {
			Debug.LogError ("oh my god , you ScrollView looks like shit ...");
		}

		GameObject itemContainerObj = new GameObject ();
		itemContainerObj.layer = LayerUtils.UI;	//Set To NGUI Layer
		itemContainer = itemContainerObj.AddComponent<UIWidget> ();
		itemContainer.name = "ItemContainer";
		itemContainer.pivot = UIWidget.Pivot.TopLeft;
		itemContainer.transform.parent = this.transform;
		itemContainer.transform.localPosition = Vector3.zero;
		itemContainer.transform.localEulerAngles = Vector3.zero;
		itemContainer.transform.localScale = Vector3.one;

		if (templateItem != null) {
			if (templateItem.transform.parent == transform) {
				templateItem.gameObject.SetActive (false);
			}
		} else {
			Transform itemTrans = transform.Find ("TemplateItem");
			if (itemTrans != null) {
				templateItem = itemTrans.GetComponent<UIScrollViewItemBase> ();
				if (templateItem != null) {
					templateItem.gameObject.SetActive (false);
				} else {
					Debug.LogError ("TemplateItem without UIScrollViewItemBase's derived Class");
				}
			}
		}

		itemCount = itemCount;//为了刷新
	}

	void Update ()
	{
		if (mScrollViewMoving) {
			UpdateItemsData (false);
		}
	}

	//拖动开始回调
	void onDragStarted()
	{
		mScrollViewMoving = true;
	}
	//拖动松手然后自动滑行结束回调
	void onStoppedMoving()
	{
		mScrollViewMoving = false;
	}

	private void CalculatePerLineCount()
	{
		int mWidth = Mathf.RoundToInt(mScrollView.panel.width);
		int mHeight = Mathf.RoundToInt(mScrollView.panel.height);

		switch (movement) {
		case Movement.Horizontal:
			perLineCount = mHeight / cellHeight;
			break;
		case Movement.Vertical:
			perLineCount = mWidth / cellWidth;
			break;
		default:
			perLineCount = 1;
			Debug.LogError ("may be you should case a new type here");
			break;
		}
	}

	//更新ItemContainer尺寸,item的数量变化时调用
	private void UpdateItemContainerSize()
	{
		if (itemContainer == null) {
			Debug.LogError ("call func too early , after Awake() will be OK");
			return;
		}

		if (itemCount <= 0) {
			itemContainer.width = 0;
			itemContainer.height = 0;
			return;
		}

		if (perLineCount == 0) {
			CalculatePerLineCount ();
		}

		int quotient = itemCount / perLineCount;
		int remainder = itemCount % perLineCount;

		switch (movement) {
		case Movement.Horizontal:
			itemContainer.width = cellWidth * CalculateCountByQuotientAndRemainder (quotient, remainder);
			itemContainer.height = cellHeight * perLineCount;
			break;
		case Movement.Vertical:
			itemContainer.width = cellWidth * perLineCount;
			itemContainer.height = cellHeight * CalculateCountByQuotientAndRemainder (quotient, remainder);
			break;
		default:
			Debug.LogError ("may be you should case a new type here");
			itemContainer.width = 10;
			itemContainer.height = 10;
			break;
		}

		completelyIndex = CalculateCountByQuotientAndRemainder (quotient, remainder) * perLineCount;
	}

	//private GameObject 
	//更新Item缓存数量,初始化和ScrollView尺寸更新时调用
	private void UpdateItemCacheCount()
	{
		if (mScrollView == null) {
			Debug.LogError ("mScrollView is null , check it !");
			enabled = false;
			return;
		}

		if (templateItem == null) {
			Debug.LogError ("templateItem is null , check it !");
			return;
		}

		int xItemCount = 0;
		int yItemCount = 0;

		int mWidth = Mathf.RoundToInt(mScrollView.panel.width);
		int mHeight = Mathf.RoundToInt(mScrollView.panel.height);

		if (perLineCount == 0) {
			CalculatePerLineCount ();
		}

		switch (movement) {
		case Movement.Horizontal:
			xItemCount = CalculateCountByQuotientAndRemainder (mWidth / cellWidth, mWidth % cellWidth) + 1;
			yItemCount = perLineCount;
			break;
		case Movement.Vertical:
			xItemCount = perLineCount;
			yItemCount = CalculateCountByQuotientAndRemainder (mHeight / cellHeight, mHeight % cellHeight) + 1;
			break;
		default:
			Debug.LogError ("may be you should case a new type here");
			xItemCount = 0;
			yItemCount = 0;
			break;
		}

		int maxCount = xItemCount * yItemCount;
		//非填满模式截取处理
		if (!fillMode) {
			maxCount = Mathf.Min (itemCount, maxCount);	
		}

		if (maxCount > cacheItems.Count) {
			int count = maxCount - cacheItems.Count;
			for (int i = 0; i < count; i++) {
				GameObject newItemObj = NGUITools.AddChild (itemContainer.gameObject, templateItem.gameObject);
				UIScrollViewItemBase temp = newItemObj.GetComponent<UIScrollViewItemBase> ();
				temp.OnInit ();

				if (onItemInstantiate != null) {
					onItemInstantiate (temp);
				}

				cacheItems.Add (temp);
			}
		}
	}

	//用商和余算最少使用数量
	private int CalculateCountByQuotientAndRemainder(int quotient, int remainder)
	{
		if (quotient < 0 || remainder < 0) {
			Debug.LogError ("fuck you bitch!");
			return 0;
		}

		if (quotient == 0 && remainder == 0) {
			return 0;
		}
		return (remainder > 0 ? (quotient + 1) : quotient);
	}

	//刷新当前所有Item数据, forceRefresh 为true 则强制刷新
	public void UpdateItemsData(bool forceRefresh = true)
	{
		int newBaginIndex = 0;
		switch (movement) {
		case Movement.Horizontal:
			int xOffset = Mathf.FloorToInt (Mathf.Max (0, mScrollView.panel.clipOffset.x));
			newBaginIndex = xOffset / cellWidth * perLineCount;
			break;
		case Movement.Vertical:
			int yOffset = Mathf.FloorToInt (Mathf.Max (0, -mScrollView.panel.clipOffset.y));
			newBaginIndex = yOffset / cellHeight * perLineCount;
			break;
		default:
			Debug.LogError ("may be you should case a new type here");
			break;
		}

		//算出当前数量下，可能的最大起始索引
		int maxBeginIndex = itemCount - cacheItems.Count;
		if (maxBeginIndex <= 0) {
			maxBeginIndex = 0;
		}

		//非填满模式截取处理
		if (!fillMode) {
			newBaginIndex = Mathf.Clamp (newBaginIndex, 0, maxBeginIndex);
		}

		if (cacheBaginIndex == -1) {
			cacheBaginIndex = 0;
			forceRefresh = true;
		}

		if (!forceRefresh && cacheBaginIndex == newBaginIndex) {
			return;
		}
			
		int deltaIndex = newBaginIndex - cacheBaginIndex;

		if (Mathf.Abs (deltaIndex) >= cacheItems.Count) {
			itemListNonius = 0;
		} else {
			itemListNonius += deltaIndex;
			if (itemListNonius >= cacheItems.Count) {
				itemListNonius = itemListNonius - cacheItems.Count;
			} else if (itemListNonius < 0) {
				itemListNonius = cacheItems.Count + itemListNonius;
			}
		}

		cacheBaginIndex = newBaginIndex;

		for (int i = 0; i < cacheItems.Count; i++) {
			int indexOffset = i + itemListNonius;
			if (indexOffset >= cacheItems.Count) {
				indexOffset = indexOffset - cacheItems.Count;
			} else if (indexOffset < 0) {
				indexOffset = cacheItems.Count + indexOffset;
			}
			SetItemData (cacheItems [indexOffset], i + cacheBaginIndex, forceRefresh);
		}
	}

	//用索引取当前显示列表中的Item,注意！索引是针对正在显示的items
	public UIScrollViewItemBase GetActiveItemByIndex(int index)
	{
		if (index < 0 || index >= cacheItems.Count) {
			return null;
		}
		int offsetIndex = itemListNonius + index;
		if (offsetIndex >= cacheItems.Count) {
			offsetIndex = offsetIndex - cacheItems.Count;
		}

		return cacheItems [offsetIndex];
	}

	//用索引获取Item在ScrollView中的坐标
	public Vector2 CalculateItemPosByIndex(int index)
	{
		float x = 0;
		float y = 0;
		Vector2 rowAndColumn = CalculateRowAndColumnByIndex (index, perLineCount);
		switch (movement) {
		case Movement.Horizontal:
			x = rowAndColumn.x * cellWidth;
			y = -rowAndColumn.y * cellHeight;
			break;
		case Movement.Vertical:
			x = rowAndColumn.y * cellWidth;
			y = -rowAndColumn.x * cellHeight;
			break;
		default:
			Debug.LogError ("may be you should case a new type here");
			break;
		}

		return new Vector2 (x, y);
	}

	//用索引获取Item在ScrollView中的坐标(算上锚点偏移值)
	public Vector2 CalculateItemFixPosByIndex(int index)
	{
		Vector2 itemPos = CalculateItemPosByIndex (index);

		// Apply the origin offset
		if (itemPivot != UIWidget.Pivot.TopLeft) {
			Vector2 po = NGUIMath.GetPivotOffset (itemPivot);
			itemPos.x += (po.x * cellWidth);
			itemPos.y -= ((1 - po.y) * cellHeight);
		}

		return itemPos;
	}

	//设置Item数据和坐标, forceRefresh 为true 则强制刷新
	private void SetItemData(UIScrollViewItemBase item, int index, bool forceRefresh)
	{
		Vector2 itemPos = CalculateItemFixPosByIndex (index);

		if (index < completelyIndex) {
			item.transform.localPosition = new Vector3 (itemPos.x, itemPos.y, 0);
			item.Show ();
			if (forceRefresh || (!forceRefresh && (item.index != index))) {
				if (index < itemCount) {
					item.SetData (index);
				} else {
                    if(fillMode)
                    {
                        item.ResetData (index);
                    }
                    else
                    {
                        item.Hide ();
                    }
				}
			}
		} else {
			item.Hide ();
		}
	}

    public void ResetAllItemsData()
    {
        for (int i = 0; i < cacheItems.Count; i++)
        {
            cacheItems[i].ResetData(0);
        }
    }


	//设置ScrollView偏移量,不带动画 Horizontal时用负数,Vertical时用正数
	public void SetScrollOffset(float offset)
	{
		Vector3 a = Vector3.zero;

		switch (movement) {
		case Movement.Horizontal:
			a = new Vector3 (offset, 0, 0);
			break;
		case Movement.Vertical:
			a = new Vector3 (0, offset, 0);
			break;
		default:
			Debug.LogError ("may be you should case a new type here");
			break;
		}

		Vector3 b = scrollView.transform.localPosition;
		scrollView.MoveRelative(a - b);

		UpdateItemsData (false);
	}

	//设置ScrollView偏移量,带动画 Horizontal时用负数,Vertical时用正数
	public void SetScrollOffsetWithAnimation(float offset, float strength = 8f, SpringPanel.OnFinished callBackFunc = null)
	{
		SpringPanel springPanel = null;
		mScrollViewMoving = true;
		scrollAnimationCallBack = callBackFunc;

		switch (movement) {
		case Movement.Horizontal:
			springPanel = SpringPanel.Begin (scrollView.gameObject, new Vector2 (offset, 0), strength);
			break;
		case Movement.Vertical:
			springPanel = SpringPanel.Begin (scrollView.gameObject, new Vector2 (0, offset), strength);
			break;
		default:
			mScrollViewMoving = false;
			callBackFunc = null;
			Debug.LogError ("may be you should case a new type here");
			break;
		}

		springPanel.onFinished = ScrollAnimationCallBack;
	}
	private SpringPanel.OnFinished scrollAnimationCallBack;
	private void ScrollAnimationCallBack()
	{
		mScrollViewMoving = false;

		if (scrollAnimationCallBack != null) {
			scrollAnimationCallBack ();
		}
		scrollAnimationCallBack = null;
	}


	/// <summary>
	/// Calculates the index of the row and column by.
	/// 传入索引和每行或列最大数量，算出该索引的二维索引，数值均从0起
	/// </summary>
	/// <returns>The row and column by index.</returns>
	/// <param name="index">Index.</param>
	/// <param name="limit">Limit.</param>
	public Vector2 CalculateRowAndColumnByIndex(int index, int limit)
	{
		if (index < 0 || limit < 0) {
			Debug.LogError ("fuck you bitch");
			return Vector2.zero;
		}

		int quotient = index / limit;
		int remainder = index % limit;

		return new Vector2 (quotient, remainder);
	}
}