using UnityEngine;
using System.Collections;

namespace XLua
{
    //Custom Delegate
    [CSharpCallLua]
    public delegate LuaTable StringReturnTable(string luaClassPath);
    [CSharpCallLua]
    public delegate string VoidReturnString();
}