using UnityEngine;
using System.Collections;

public class LuaConst
{
    public static string LuaEditorPath = Application.dataPath + "/Main/LuaScripts/";	//lua 代码路径

    public static string LuaFolderName = "luatemp";
    public static string LuaBundleName = "lua.dat";
    public static string LuaPostfixName = ".lua.bytes";
    public static string LuaEditorBundlePath
    {
        get { return Application.streamingAssetsPath; }
    }

    public static string LuaAndroidBundlePath
    {
        get
        {
            return Application.streamingAssetsPath;
        }
    }

    public static string LuaIosBundlePath
    {
        get
        {
            return Application.streamingAssetsPath;
            //return Application.dataPath + "/Raw/";
        }
    }

    public static string LuaBundlePath
    {
        get
        {
#if UNITY_EDITOR || UNITY_STANDALONE
            return System.IO.Path.Combine(LuaAndroidBundlePath, LuaBundleName);
#elif UNITY_ANDROID
            return System.IO.Path.Combine(LuaAndroidBundlePath, LuaBundleName);
#elif UNITY_IPHONE
            return System.IO.Path.Combine(LuaIosBundlePath, LuaBundleName);
#endif
        }
    }
}