using UnityEngine;
using System.Collections;
using XLua;

//Custom Delegate
public class LuaCustomDelegate
{
    [CSharpCallLua]
    public delegate LuaTable StringReturnTable(string luaClassPath);
}