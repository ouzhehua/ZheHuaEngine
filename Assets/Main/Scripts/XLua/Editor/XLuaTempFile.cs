using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class XLuaTempFile
{
    [MenuItem("XLua/CreateLuaBytes", false, 100)]
    public static void ChangeFileExtension()
    {
        DirectoryInfo dir = new DirectoryInfo(Application.dataPath + "/Main/LuaScripts/");
        string path = Path.Combine(Application.dataPath, "Main/LuaTemp/");
        if (Directory.Exists(path) == true)
        {
            Directory.Delete(path, true);
        }
        Directory.CreateDirectory(path);
        ChangeFileExtensionInDir(dir);
        AssetDatabase.ImportAsset("Assets/Main/LuaTemp", ImportAssetOptions.ImportRecursive);
        UnityEngine.Debug.Log("CreateLuaBytes Finished");
    }

    private static void ChangeFileExtensionInDir(DirectoryInfo dir)
    {
        FileInfo[] info = dir.GetFiles();
        DirectoryInfo[] subDirInfo = dir.GetDirectories();
        foreach (DirectoryInfo subDir in subDirInfo)
        {
            string newDir = subDir.FullName.Replace("LuaScripts", "LuaTemp");
            if (Directory.Exists(newDir) == false)
            {
                Directory.CreateDirectory(newDir);
            }
            ChangeFileExtensionInDir(subDir);
        }
        foreach (FileInfo file in info)
        {
            if (file.Name.EndsWith(".lua"))
            {
                string newFile = file.FullName.Replace("LuaScripts", "LuaTemp") + ".bytes";
                file.CopyTo(newFile, true);
            }
        }
    }

    [MenuItem("XLua/DeleteLuaBytes", false, 101)]
    public static void DeleteLuaBytes()
    {
        AssetDatabase.DeleteAsset("Assets/Main/LuaTemp");
        UnityEngine.Debug.Log("DeleteLuaBytes Finished");
    }
}