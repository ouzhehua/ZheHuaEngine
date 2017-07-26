using UnityEngine;
using System.Collections;

public class LuaConst
{
    public static string LuaEditorPath = Application.dataPath + "/Main/LuaScripts/";	//lua 代码路径

    public static string LuaBundleName = "lua.dat";

    public static string LuaEditorBundlePath
    {
        get { return Application.streamingAssetsPath; }
    }

    public static string LuaAndroidBundlePath
    {
        get
        {
            return "jar:file://" + Application.dataPath + "!/assets/";
        }
    }

    public static string LuaIosBundlePath
    {
        get
        {
            return Application.dataPath + "/Raw/";
        }
    }

    public static string LuaBundlePath
    {
        get
        {
#if UNITY_ANDROID
            return LuaAndroidBundlePath + LuaBundleName;
#elif UNITY_IPHONE
            return LuaIosBundlePath + LuaBundleName;
#elif UNITY_STANDALONE_WIN || UNITY_EDITOR
            return LuaEditorBundlePath + "/" + LuaBundleName;
#else
            Debug.LogError("Without This Platform");
            string.Empty;
#endif
        }
    }
}