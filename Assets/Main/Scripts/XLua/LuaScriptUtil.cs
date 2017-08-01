using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LuaScriptUtil
{
    public static void AddLuaFunctionDelegate(List<EventDelegate> list, XLua.LuaFunction func)
    {
        EventDelegate.Add(list, delegate()
        {
            func.Call();
        });
    }

    public static void SetLuaFunctionDelegate(List<EventDelegate> list, XLua.LuaFunction func)
    {
        EventDelegate.Set(list, delegate()
        {
            func.Call();
        });
    }
}