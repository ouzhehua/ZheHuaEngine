//----------------------------------------------
//	auth:zhehua
//----------------------------------------------

using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class FolderBatchOperateTool : EditorWindow
{
    [MenuItem("Tools/QuickCheckHelper/Folder Batch Operate Tool", false, 102)]
    static public void OpenNGUIChecker()
    {
        FolderBatchOperateTool window = EditorWindow.GetWindow<FolderBatchOperateTool>(false, "Folder Tool");
        window.minSize = window.maxSize = new Vector2(DefaultWidth, DefaultHeight);
        window.Show();   
    }

    static public FolderBatchOperateTool instance;

    void OnEnable() { instance = this; }
    void OnDisable() { instance = null; }

    public const int DefaultWidth = 770;
    public const int DefaultHeight = 420;

    private string sourceRootPath;
    private bool needRefresh = false;

    private enum TargetType
    {
        File,
        Folder
    }

    private enum OperateType
    {
        Delete,
        Rename
    }

    private TargetType targetType = TargetType.File;
    private OperateType operateType = OperateType.Rename;
    
    private string keyWord = "";
    private string extension = "";

    private bool isLocking = false;

    void Awake()
    {
        sourceRootPath = Application.dataPath;
    }

    void OnGUI ()
    {
        EditorGUILayout.Space();
        EditorGUI.BeginDisabledGroup(isLocking);

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Source Root Path", GUILayout.Width(116)))
        {
            sourceRootPath = EditorUtility.OpenFolderPanel("Select Path", Application.dataPath, "");
            needRefresh = true;
        }
        sourceRootPath = EditorGUILayout.TextField(sourceRootPath);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("TargetType :", GUILayout.Width(80));
        targetType = (TargetType)EditorGUILayout.EnumPopup(targetType, GUILayout.Width(60));

        EditorGUILayout.LabelField("OperateType :", GUILayout.Width(90));
        operateType = (OperateType)EditorGUILayout.EnumPopup(operateType, GUILayout.Width(70));

        EditorGUILayout.LabelField("KeyWord :", GUILayout.Width(64));
        keyWord = EditorGUILayout.TextField(keyWord, GUILayout.Width(150));

        EditorGUI.BeginDisabledGroup(targetType != TargetType.File);
        EditorGUILayout.LabelField("Extension :", GUILayout.Width(70));
        extension = EditorGUILayout.TextField(extension, GUILayout.Width(150));
        EditorGUI.EndDisabledGroup();
        EditorGUILayout.EndHorizontal();

        EditorGUI.EndDisabledGroup();

        if (isLocking)
        {
            if (GUILayout.Button("Return To Main Page"))
            {
                isLocking = false;
            }
            DrawToDoList();
        }
        else
        {
            if (GUILayout.Button("Search And Show List"))
            {
                isLocking = true;
                _scrollViewPos = Vector2.zero;
                CreateToDoList();
            }
        }


        if (needRefresh)
        {
            needRefresh = false;
            OnGUI();
        }
    }

    Vector2 _scrollViewPos = Vector2.zero;
    List<string> _includeKeyWords;
    List<string> _excludeKeyWords;
    List<string> _normalKeyWords;
    List<string> _includeExtensions;
    List<TodoList> _todoList;
    List<string> _tryRenameList;
    public struct TodoList
    {
        //public string path;
        public string parentPath;
        public string name;
        public string extension;
    }
    
    void CreateToDoList()
    {
        if (string.IsNullOrEmpty(keyWord))
        {
            _includeKeyWords = null;
            _excludeKeyWords = null;
            _normalKeyWords = null;
        }
        else
        {
            string[] temp = keyWord.Trim().Split(' ');
            _includeKeyWords = new List<string>();
            _excludeKeyWords = new List<string>();
            _normalKeyWords = new List<string>();
            for (int i = 0; i < temp.Length; i++)
            {
                Char firstChar = temp[i][0];
                if (firstChar == '+')
                {
                    _includeKeyWords.Add(temp[i].Substring(1));
                }
                else if (firstChar == '-')
                {
                    _excludeKeyWords.Add(temp[i].Substring(1));
                }
                else
                {
                    _normalKeyWords.Add(temp[i]);
                }
            }
        }

        

        _todoList = new List<TodoList>();
        switch(targetType)
        {
            case TargetType.File:
                if (string.IsNullOrEmpty(extension))
                {
                    _includeExtensions = null;
                }
                else
                {
                    _includeExtensions = new List<string>(extension.Trim().Split(' '));
                }
                //生成文件列表
                GetAllFilesByPath(sourceRootPath, ref _todoList);
                break;
            case TargetType.Folder:
                //生成文件夹列表
                GetAllFolderByPath(sourceRootPath, ref _todoList);
                break;
            default:
                Debug.LogError("you should case " + operateType);
                break;
        }
        
        _tryRenameList = null;
    }

    void DrawToDoList()
    {
        EditorGUILayout.BeginVertical(GUILayout.Height(300), GUILayout.Width(DefaultWidth));
        _scrollViewPos = EditorGUILayout.BeginScrollView(_scrollViewPos, GUILayout.Width(DefaultWidth - 10));

        if (_todoList == null)
        {
            _todoList = new List<TodoList>();
        }

        switch (operateType)
        {
            case OperateType.Delete:
                DrawDeleteList();
                break;
            case OperateType.Rename:
                DrawRenameList();
                break;
            default:
                Debug.LogError("you should case " + operateType);
                break;
        }

        EditorGUILayout.EndScrollView();
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Count : " + _todoList.Count, GUILayout.Width(80));
        if (operateType == OperateType.Rename)
        {
            EditorGUILayout.LabelField("SourceStr :", GUILayout.Width(66));
            sourceStr = EditorGUILayout.TextField(sourceStr, GUILayout.Width(150));
            EditorGUILayout.LabelField("FinalStr :", GUILayout.Width(64));
            finalStr = EditorGUILayout.TextField(finalStr, GUILayout.Width(150));
            if (GUILayout.Button("Try", GUILayout.Width(66)))
            {
                if (!string.IsNullOrEmpty(sourceStr))
                {
                    _tryRenameList = new List<string>();
                    for (int i = 0; i < _todoList.Count; i++)
                    {
                        _tryRenameList.Add(_todoList[i].name.Replace(sourceStr, finalStr));
                    }
                }
            }
        }
        EditorGUILayout.EndHorizontal();

        if (GUILayout.Button("One Key Done"))
        {
            switch (operateType)
            {
                case OperateType.Delete:
                    OneKeyDelete();
                    break;
                case OperateType.Rename:
                    OneKeyRename();
                    break;
                default:
                    Debug.LogError("you should case " + operateType);
                    break;
            }
            
            needRefresh = true;
        }
    }

    void DrawDeleteList()
    {
        switch (targetType)
        {
            case TargetType.File:
                DrawDeleteFileList();
                break;
            case TargetType.Folder:
                DrawDeleteFolderList();
                break;
            default:
                Debug.LogError("you should case " + targetType);
                break;
        }
    }

    void DrawDeleteFileList()
    {
        for (int i = 0; i < _todoList.Count; i++)
        {
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.LabelField(_todoList[i].parentPath + "/" + _todoList[i].name + _todoList[i].extension, GUILayout.Width(550));

            if (GUILayout.Button("Delete"))
            {
                AssetDatabase.DeleteAsset(_todoList[i].parentPath + "/" + _todoList[i].name + _todoList[i].extension);
                AssetDatabase.Refresh();
                _todoList.RemoveAt(i);
                needRefresh = true;
            }

            EditorGUILayout.EndHorizontal();
        }
    }

    void DrawDeleteFolderList()
    {
        for (int i = 0; i < _todoList.Count; i++)
        {
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.LabelField(_todoList[i].parentPath + "/" + _todoList[i].name, GUILayout.Width(550));

            if (GUILayout.Button("Delete"))
            {
                string path = _todoList[i].parentPath + "/" + _todoList[i].name;
                if(Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    AssetDatabase.Refresh();
                    _todoList.RemoveAt(i);
                    needRefresh = true;
                }
                else
                {
                    Debug.LogError("may be " + path + " no longer exists");
                }
            }

            EditorGUILayout.EndHorizontal();
        }
    }

    string sourceStr;
    string finalStr;
    void DrawRenameList()
    {
        switch(targetType)
        {
            case TargetType.File:
                DrawRenameFileList();
                break;
            case TargetType.Folder:
                DrawRenameFolderList();
                break;
            default:
                Debug.LogError("you should case " + targetType);
                break;
        }
    }

    void DrawRenameFileList()
    {
        for (int i = 0; i < _todoList.Count; i++)
        {
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.LabelField(_todoList[i].parentPath + "/" + _todoList[i].name + _todoList[i].extension, GUILayout.Width(550));

            if (_tryRenameList != null)
            {
                EditorGUILayout.LabelField(_tryRenameList[i], GUILayout.Width(250));

                if (_todoList[i].name != _tryRenameList[i])
                {
                    if (GUILayout.Button("Rename"))
                    {
                        AssetDatabase.RenameAsset(_todoList[i].parentPath + "/" + _todoList[i].name + _todoList[i].extension, _tryRenameList[i]);
                        AssetDatabase.SaveAssets();
                        AssetDatabase.Refresh();
                        _todoList.RemoveAt(i);
                        _tryRenameList.RemoveAt(i);
                        needRefresh = true;
                    }
                }
            }
            //EditorGUILayout.SelectableLabel(_todoList[i].path + "  " + _todoList[i].name, GUILayout.Height(16));
            EditorGUILayout.EndHorizontal();
        }
    }

    void DrawRenameFolderList()
    {
        for (int i = 0; i < _todoList.Count; i++)
        {
            EditorGUILayout.BeginHorizontal();

            EditorGUILayout.LabelField(_todoList[i].parentPath + "/" + _todoList[i].name, GUILayout.Width(550));

            if (_tryRenameList != null)
            {
                EditorGUILayout.LabelField(_tryRenameList[i], GUILayout.Width(250));

                if (_todoList[i].name != _tryRenameList[i])
                {
                    if (GUILayout.Button("Rename"))
                    {
                        string path = _todoList[i].parentPath + "/" + _todoList[i].name;
                        if (Directory.Exists(path))
                        {
                            Directory.Move(path, _todoList[i].parentPath + "/" + _tryRenameList[i]);
                        }
                        AssetDatabase.SaveAssets();
                        AssetDatabase.Refresh();
                        _todoList.RemoveAt(i);
                        _tryRenameList.RemoveAt(i);
                        needRefresh = true;
                    }
                }
            }
            EditorGUILayout.EndHorizontal();
        }
    }

    void OneKeyDelete()
    {
        switch (targetType)
        {
            case TargetType.File:
                for (int i = 0; i < _todoList.Count; i++)
                {
                    AssetDatabase.DeleteAsset(_todoList[i].parentPath + "/" + _todoList[i].name + _todoList[i].extension);
                }
                AssetDatabase.Refresh();
                _todoList.Clear();
                needRefresh = true;
                break;
            case TargetType.Folder:
                for (int i = 0; i < _todoList.Count; i++)
                {
                    string path = _todoList[i].parentPath + "/" + _todoList[i].name;
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                    }
                }
                AssetDatabase.Refresh();
                _todoList.Clear();
                needRefresh = true;
                break;
            default:
                Debug.LogError("you should case " + targetType);
                break;
        }
    }

    void OneKeyRename()
    {
        if (_tryRenameList == null)
        {
            return;
        }

        switch (targetType)
        {
            case TargetType.File:
                for (int i = 0; i < _todoList.Count; i++)
                {
                    if (_todoList[i].name != _tryRenameList[i])
                    {
                        AssetDatabase.RenameAsset(_todoList[i].parentPath + "/" + _todoList[i].name + _todoList[i].extension, _tryRenameList[i]);
                        needRefresh = true;
                    }
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
                }
                _todoList.Clear();
                _tryRenameList.Clear();
                break;
            case TargetType.Folder:
                for (int i = 0; i < _todoList.Count; i++)
                {
                    if (_todoList[i].name != _tryRenameList[i])
                    {
                        string path = _todoList[i].parentPath + "/" + _todoList[i].name;
                        if (Directory.Exists(path))
                        {
                            Directory.Move(path, _todoList[i].parentPath + "/" + _tryRenameList[i]);
                        }
                        needRefresh = true;
                    }
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
                }
                _todoList.Clear();
                _tryRenameList.Clear();
                break;
            default:
                Debug.LogError("you should case " + targetType);
                break;
        }
    }

    //过滤出待处理文件
    public void GetAllFilesByPath(string dirPath, ref List<TodoList> sourceList)
    {
        string path = dirPath.Substring(dirPath.IndexOf("Assets"));
        string currentExtension;
        foreach (string fullPath in Directory.GetFiles(dirPath)) {
            currentExtension = System.IO.Path.GetExtension(fullPath);
            if (_includeExtensions == null || _includeExtensions.IndexOf(currentExtension) != -1) { //Extension
                string fileName = System.IO.Path.GetFileNameWithoutExtension(fullPath);
                bool exclude = false;
                if (_normalKeyWords == null) {
                    exclude = true;
                } else {
                    for (int i = 0; i < _normalKeyWords.Count; i++) {
                        if (fileName.Contains(_normalKeyWords[i])) {
                            exclude = true;
                            break;
                        }
                    }
                }

                if(exclude) {
                    TodoList temp = new TodoList();
                    temp.parentPath = path;
                    temp.name = fileName;
                    temp.extension = currentExtension;
                    //temp.path = temp.parentPath + "/" + temp.name + temp.extension;
                    sourceList.Add(temp);
                }
			}
        }

        if (Directory.GetDirectories(dirPath).Length > 0) {
            foreach (string fullPath in Directory.GetDirectories(dirPath)) {
                GetAllFilesByPath(fullPath, ref sourceList);
            }
        }
    }

    public void GetAllFolderByPath(string dirPath, ref List<TodoList> sourceList)
    {
        DirectoryInfo currentInfo = new DirectoryInfo(dirPath);
        DirectoryInfo[] childrenList = currentInfo.GetDirectories();

        for (int i = 0; i < childrenList.Length; i++)
        {
            string folderName = childrenList[i].Name;
            bool exclude = false;
            if (_normalKeyWords == null)
            {
                exclude = true;
            }
            else
            {
                for (int j = 0; j < _normalKeyWords.Count; j++)
                {
                    if (folderName.Contains(_normalKeyWords[j]))
                    {
                        exclude = true;
                        break;
                    }
                }
            }

            if (exclude)
            {
                TodoList temp = new TodoList();
                temp.parentPath = dirPath;
                temp.name = folderName;
                //temp.extension = childrenList[i].Extension;
                //temp.path = temp.parentPath + "/" + temp.name + temp.extension;

                sourceList.Add(temp);
            }

            GetAllFolderByPath(childrenList[i].FullName, ref sourceList);
        }
    }
}