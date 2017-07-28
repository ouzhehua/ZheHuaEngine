using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
using System.IO;

[CustomEditor(typeof(SpriteCheckTools))]
public class SpriteCheckToolsEditor : Editor
{
    private bool _needRefresh = false;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector ();
        SpriteCheckTools self = (SpriteCheckTools)target;
        
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Source Root Path", GUILayout.Width(116)))
        {
            self.sourceRootPath = EditorUtility.OpenFolderPanel("Select Path", Application.dataPath, "");
            _needRefresh = true;
        }
        self.sourceRootPath = EditorGUILayout.TextField(self.sourceRootPath);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        if (Directory.Exists(self.sourceRootPath))
        {
            if (GUILayout.Button("Find All Source"))
            {
                self.FindAllSource();
                _needRefresh = true;
            }


            EditorGUILayout.LabelField("Source Atlas : " + self.usefulAtlas.Count);
            if (self.usefulAtlas.Count > 0)
            {
                int usefulAtlasCount = self.usefulAtlas.Count;
                int row = usefulAtlasCount / 3;
                int column = usefulAtlasCount % 3;
                if (column > 0) row++;

                for (int i = 0; i < row; i++)
                {
                    EditorGUILayout.BeginHorizontal();
                    for (int j = 0; j < 3; j++)
                    {
                        int index = i * 3 + j;
                        if (index < usefulAtlasCount)
                            EditorGUILayout.ObjectField(self.usefulAtlas[index], typeof(GameObject), GUILayout.Width(110));
                    }
                    EditorGUILayout.EndHorizontal();
                }

                if (GUILayout.Button("Check Invalid Sprite"))
                {
                    self.CheckSpriteState();
                    _needRefresh = true;
                }

                if(self.todoList.Count > 0)
                {
                    for (int i = 0; i < self.todoList.Count; i++)
                    {
                        EditorGUILayout.BeginHorizontal();
                        
                        EditorGUILayout.ObjectField(self.todoList[i].gameObject, typeof(GameObject), GUILayout.Width(110));
                        if (self.todoList[i].indexs.Count > 0)
                        {
                            EditorGUILayout.LabelField("------>", GUILayout.Width(50));
                            for (int j = 0; j < self.todoList[i].indexs.Count; j++)
                            {
                                int index = self.todoList[i].indexs[j];
                                if (GUILayout.Button(self.usefulAtlas[index].name, GUILayout.Width(90)))
                                {
                                    self.todoList[i].gameObject.GetComponent<UISprite>().atlas = self.usefulAtlas[self.todoList[i].indexs[j]];
                                    self.CheckSpriteState();
                                    _needRefresh = true;
                                }
                            }
                        }
                        else
                        {
                            EditorGUILayout.LabelField("without match atlas");
                        }
                        
                        
                        EditorGUILayout.EndHorizontal();
                    }

                    if (GUILayout.Button("One Key Replace Explicit Atlas"))
                    {
                        self.SwitchAtlas();
                        self.CheckSpriteState();
                        _needRefresh = true;
                    }
                }
            }
            else
            {
                EditorGUILayout.LabelField("without source");
            }
        }
        else
        {
            EditorGUILayout.LabelField("set useful source root path , please");
        }

        if (_needRefresh)
        {
            _needRefresh = false;
            OnInspectorGUI();
        }
    }

    [MenuItem("NGUI/Sprite Check Tools &s", false, 100)]
    public static void AddSpriteCheckTools()
    {
        GameObject go = Selection.activeGameObject;

        if (go != null)
        {
            SpriteCheckTools temp = go.GetComponent<SpriteCheckTools>();
            if (temp == null)
            {
                go.AddComponent<SpriteCheckTools>();
            }
            else
            {
                Debug.Log("help you delete");
                DestroyImmediate(temp);
            }
        }
        else GameFramework.Log.Info("You must select a game object first.");
    }
}

#endif
public class SpriteCheckTools : MonoBehaviour
{
    [HideInInspector]
    public string sourceRootPath = Application.dataPath + "/Main/UI/Atlas";

    private List<UIAtlas> _usefulAtlas = new List<UIAtlas>();
    public List<UIAtlas> usefulAtlas { get { return _usefulAtlas; } }

    private List<SwitchSpriteData> _todoList = new List<SwitchSpriteData>();
    public List<SwitchSpriteData> todoList { get { return _todoList; } }

    public struct SwitchSpriteData
    {
        public GameObject gameObject;
        public List<int> indexs;
    }

    void Awake()
    {
        if (Application.isPlaying)
        {
            Debug.LogError("操你妈！谁让你把我带到游戏里的，我只是个监测工具，快删了 " + gameObject.name);
        }
    }
#if UNITY_EDITOR
    public void FindAllSource()
    {
        _usefulAtlas.Clear();

        List<string> allPrefabsPath = new List<string>();
        GetAllFilesByPath(sourceRootPath, ref allPrefabsPath);

        for (int i = 0; i < allPrefabsPath.Count; i++)
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(allPrefabsPath[i]);
            UIAtlas current = prefab.GetComponent<UIAtlas>();
            if (current != null)
            {
                _usefulAtlas.Add(current);
            }
        }
    }

    public void CheckSpriteState()
    {
        _todoList.Clear();

        if (_usefulAtlas.Count > 0)
        {
            UISprite[] components = gameObject.GetComponentsInChildren<UISprite>(true);
            int count = components.Length;
            for (int i = 0; i < count; i++)
            {
                if (components[i].atlas == null || components[i].atlas.GetSprite(components [i].spriteName) == null)
                {
                    SwitchSpriteData data;
                    data.gameObject = components[i].gameObject;
                    data.indexs = new List<int>();

                    for (int j = 0; j < _usefulAtlas.Count; j++)
                    {
                        if (_usefulAtlas[j].GetSprite(components[i].spriteName) != null)
                        {
                            data.indexs.Add(j);
                        }
                    }
                    _todoList.Add(data);
                }
            }
        }
        else
        {
            Debug.LogError("usefulAtlas 's count equals 0");
        }
    }

    public void SwitchAtlas()
    {
        for (int i = 0; i < _todoList.Count; i++)
        {
            if(_todoList[i].indexs.Count == 1)
            {
                _todoList[i].gameObject.GetComponent<UISprite>().atlas = _usefulAtlas[_todoList[i].indexs[0]];
            }
        }
    }


    public static void GetAllFilesByPath(string dirPath, ref List<string> sourceList, string extension = ".prefab")
    {
        foreach (string path in Directory.GetFiles(dirPath))
        {
            //获取所有文件夹中包含后缀为 .prefab 的路径  
            if (System.IO.Path.GetExtension(path) == extension)
            {
                sourceList.Add(path.Substring(path.IndexOf("Assets")));
            }
        }
        
        if (Directory.GetDirectories(dirPath).Length > 0)  //遍历所有文件夹  
        {
            foreach (string path in Directory.GetDirectories(dirPath))
            {
                GetAllFilesByPath(path, ref sourceList, extension);
            }
        }
    }
#endif
}