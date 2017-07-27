//----------------------------------------------
//	auth:zhehua
//----------------------------------------------

using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class NGUIChecker : EditorWindow
{
	[MenuItem("NGUI/NGUIChecker", false, 100)]
	static public void OpenNGUIChecker ()
	{
		NGUIChecker window = EditorWindow.GetWindow<NGUIChecker>(false, "NGUI Checker");
		window.minSize = window.maxSize = new Vector2(DefaultWidth, DefaultHeight);
		window.Show();
	}

	static public NGUIChecker instance;

	void OnEnable () { instance = this; }
	void OnDisable () { instance = null; }

	public const int DefaultWidth = 500;
	public const int DefaultHeight = 400;

	private enum CheckerMode
	{
		Idle,
		CheckFont,
		CheckSprite,
		CheckTextureMask,
	}

	private CheckerMode currentMode = CheckerMode.Idle;

	private string _FolderPath = "";
	private List<string> _NoticeIntroduce;

	private bool _needRefresh = false;
	private bool _isPathValid = false;

    public struct ProblemItem
    {
        public GameObject prefab;
        public List<string> noticeStr;
    }
    public List<ProblemItem> todoList = new List<ProblemItem>();

	void Awake ()
	{
        _FolderPath = Application.dataPath + "/Main/Prefabs/UI";

		_NoticeIntroduce = new List<string> ();
        _NoticeIntroduce.Add("1. CheckFont : 检查路径下所有prefab里的UIFont是否符合规范");
        _NoticeIntroduce.Add("2. CheckSprite : 检查路径下所有prefab里的UISprite是否符合规范");
        _NoticeIntroduce.Add("3. CheckTextureMask : 检查路径下所有prefab里的UIPanel里的TextureMask是否丢失");
	}

	void OnGUI ()
	{
		EditorGUILayout.Space();

		EditorGUILayout.BeginHorizontal(GUILayout.Width(DefaultWidth));

		EditorGUILayout.LabelField("Folder Path", GUILayout.Width(70));
		EditorGUILayout.TextField(_FolderPath, GUILayout.Width(350));

		if (GUILayout.Button("Choose", GUILayout.Width(60)))
		{
			_FolderPath = EditorUtility.OpenFolderPanel("Select Pack File", Application.dataPath, "");
			Debug.Log("Chose Folder Path " + _FolderPath);
			_needRefresh = true;
		}

		EditorGUILayout.EndHorizontal();

		_isPathValid = Directory.Exists (_FolderPath);

        EditorGUI.BeginDisabledGroup(!(_isPathValid && currentMode == CheckerMode.Idle));
        DrawBtns();
        EditorGUI.EndDisabledGroup();

		DrawNoticeList ();
		DrawControlArea ();


		if (_needRefresh)
		{
			_needRefresh = false;
			OnGUI();
		}
	}


	void DrawBtns()
	{
		EditorGUILayout.BeginHorizontal(GUILayout.Width(DefaultWidth));

		if (GUILayout.Button ("Find Unity Font", GUILayout.Width (140)))
		{
			_scrollViewPos = Vector2.zero;
			currentMode = CheckerMode.CheckFont;
			CheckFontResult ();
		}

		if (GUILayout.Button ("Find Invalid Sprite", GUILayout.Width (140)))
		{
			_scrollViewPos = Vector2.zero;
			currentMode = CheckerMode.CheckSprite;
			CheckAtlasResult ();
		}

        if (GUILayout.Button ("Find TextureMask", GUILayout.Width(140)))
		{
			_scrollViewPos = Vector2.zero;
            currentMode = CheckerMode.CheckTextureMask;
            CheckTextureMaskResult();
		}

		EditorGUILayout.EndHorizontal();
	}

	void CheckFontResult()
	{
        todoList.Clear();

        List<string> allPrefabsPath = new List<string>();
        GetAllFilesByPath(_FolderPath, ref allPrefabsPath);

        for (int i = 0; i < allPrefabsPath.Count; i++)
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(allPrefabsPath[i]);
            List<string> result = new List<string>();

            UILabel[] labelComps = prefab.GetComponentsInChildren<UILabel>(true);
            for (int j = 0; j < labelComps.Length; j++)
            {
                Font font = labelComps[j].trueTypeFont;
                if (labelComps[j].enabled == false)
                {
                    result.Add(labelComps[j].name + " UILable 的勾没勾上 ");
                }
                else if (font == null)
                {
                    result.Add(labelComps[j].name + " Lable 上没字体 ");
                }
                else if (labelComps[j].bitmapFont == null)
                {
                    result.Add(labelComps[j].name + " Lable 上用了Unity字体 " + font.name);
                }
            }

            if(result.Count>0)
            {
                ProblemItem temp;
                temp.prefab = prefab;
                temp.noticeStr = result;
                todoList.Add(temp);
            }
        }
	}

	GameObject targetFont;
	void DrawFontControlArea()
	{
		EditorGUILayout.LabelField ("替换字体:",GUILayout.Width(60));
		targetFont = (GameObject)EditorGUILayout.ObjectField(targetFont, typeof(GameObject), false, GUILayout.Width(200));

		if (targetFont != null)
		{
			UIFont temp = targetFont.GetComponent<UIFont> ();
			if (temp == null)
			{
				targetFont = null;
				Debug.LogError ("请选UIFont Prefab");
			}

			if (targetFont != null)
			{
				if (GUILayout.Button ("一键替换", GUILayout.Width (60)))
				{
					ReturnToIdleMode ();
				}
			}
		}

		DrawReturnBtn ();
	}

	void CheckAtlasResult()
	{
        todoList.Clear();

        List<string> allPrefabsPath = new List<string>();
        GetAllFilesByPath(_FolderPath, ref allPrefabsPath);

        for (int i = 0; i < allPrefabsPath.Count; i++)
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(allPrefabsPath[i]);
            List<string> result = new List<string>();

            UISprite[] spriteComps = prefab.GetComponentsInChildren<UISprite>(true);
            for (int j = 0; j < spriteComps.Length; j++)
            {
                if (spriteComps[j].enabled == false)
                {
                    result.Add(spriteComps[j].name + " Sprite 的勾没勾上 ");
                }
                else if (spriteComps[j].atlas == null)
                {
                    result.Add(spriteComps[j].name + " Sprite 上没 Atlas ");
                }
                else if (spriteComps[j].atlas.GetSprite(spriteComps[j].spriteName) == null)
                {
                    result.Add(spriteComps[j].name + " Sprite 上 " + spriteComps[j].spriteName + " 无效 ");
                }
            }

            if (result.Count > 0)
            {
                ProblemItem temp;
                temp.prefab = prefab;
                temp.noticeStr = result;
                todoList.Add(temp);
            }
        }
	}

    void CheckTextureMaskResult()
	{
        todoList.Clear();

        List<string> allPrefabsPath = new List<string>();
        GetAllFilesByPath(_FolderPath, ref allPrefabsPath);

        for (int i = 0; i < allPrefabsPath.Count; i++)
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(allPrefabsPath[i]);
            List<string> result = new List<string>();

            UIPanel[] panelComps = prefab.GetComponentsInChildren<UIPanel>(true);
            for (int j = 0; j < panelComps.Length; j++)
            {
                if (panelComps[j].clipping == UIDrawCall.Clipping.TextureMask && panelComps[j].clipTexture == null)
                {
                    result.Add(panelComps[j].name + " 上的遮罩图丢了");
                }
            }

            if (result.Count > 0)
            {
                ProblemItem temp;
                temp.prefab = prefab;
                temp.noticeStr = result;
                todoList.Add(temp);
            }
        }
	}

	void ReturnToIdleMode()
	{
        todoList.Clear();
		currentMode = CheckerMode.Idle;
	}

	Vector2 _scrollViewPos = Vector2.zero;
	void DrawNoticeList()
	{
		EditorGUILayout.Space();
		EditorGUILayout.BeginVertical(GUILayout.Height(300), GUILayout.Width(DefaultWidth));

        _scrollViewPos = EditorGUILayout.BeginScrollView (_scrollViewPos, GUILayout.Width (DefaultWidth - 10));

		if (currentMode == CheckerMode.Idle)
		{
            for(int i = 0 ; i < _NoticeIntroduce.Count ; i++)
		    {
			    EditorGUILayout.LabelField(_NoticeIntroduce[i]);
		    }
		}
		else
		{
            if (todoList != null && todoList.Count > 0)
			{
                for (int i = 0; i < todoList.Count; i++)
                {
                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.ObjectField(todoList[i].prefab, typeof(GameObject), false, GUILayout.Width(150));

                    EditorGUILayout.BeginVertical();

                    for (int j = 0; j < todoList[i].noticeStr.Count; j++)
                    {
                        EditorGUILayout.TextField(todoList[i].noticeStr[j]);
                    }

                    EditorGUILayout.EndVertical();

                    EditorGUILayout.EndHorizontal();
                }
			}
			else
			{
				EditorGUILayout.LabelField("很好，没有异常文件");
			}
		}

		EditorGUILayout.EndScrollView();

		EditorGUILayout.EndVertical();
	}

	void DrawControlArea()
	{
		EditorGUILayout.BeginHorizontal ();

        if (todoList != null && todoList.Count > 0)
		{
            EditorGUILayout.LabelField("共找到: " + todoList.Count + " 个", GUILayout.Width(120));
		}

		switch(currentMode)
		{
		case CheckerMode.CheckFont:
			//DrawFontControlArea ();
			DrawReturnBtn ();
			break;
		case CheckerMode.CheckSprite:
			DrawReturnBtn ();
			break;
        case CheckerMode.CheckTextureMask:
			DrawReturnBtn ();
			break;
		default:
			break;
		}

		EditorGUILayout.EndHorizontal ();
	}

	void DrawReturnBtn()
	{
		if (GUILayout.Button ("返回", GUILayout.Width (50)))
		{
			ReturnToIdleMode ();
		}
	}


    //获取文件夹下所有符合后缀的文件资源路径，包括子目录
    public static void GetAllFilesByPath(string dirPath, ref List<string> sourceList, string extension = ".prefab")
    {
        foreach (string path in Directory.GetFiles(dirPath))
        {
            if (System.IO.Path.GetExtension(path) == extension)
            {
                sourceList.Add(path.Substring(path.IndexOf("Assets")));
            }
        }

        if (Directory.GetDirectories(dirPath).Length > 0)
        {
            foreach (string path in Directory.GetDirectories(dirPath))
            {
                GetAllFilesByPath(path, ref sourceList, extension);
            }
        }
    }
}