/// <summary>
/// add by ouzhehua
/// UIScrollView 的 Item 的数据管理基类
/// </summary>

using UnityEngine;
using System.Collections;

public class UIScrollViewItemBase : MonoBehaviour
{
	protected int mIndex = -1;

	//索引
	public int index{ get { return mIndex; } }

	//被UIScrollViewRecycle创建时会调这个
	public virtual void OnInit()
	{
	}

	//用索引取数据函数模版
	public delegate T GetDataByIndex<T>(int index);

	//显示Item，基本不用重写
	public virtual void Show()
	{
		gameObject.SetActive (true);
	}

	//隐藏Item，基本不用重写
	public virtual void Hide()
	{
		gameObject.SetActive (false);
	}

	//这个当然要重写
	public virtual void SetData(int index)
	{
		mIndex = index;
	}

	//需要显示空格子样式就重写
	public virtual void ResetData(int index)
	{
		mIndex = index;
	}

    //设置数据之后回调函数
    public delegate void setDataCallBack(object obj,object itemObj);
}