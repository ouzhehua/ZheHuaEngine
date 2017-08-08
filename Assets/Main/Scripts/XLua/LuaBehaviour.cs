using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;

[System.Serializable]
public class Injection
{
    public string name;
    public GameObject value;
}

[LuaCallCSharp]
public class LuaBehaviour : MonoBehaviour
{
    public string LuaFilePath;
    public Injection[] injections;

    private Action<LuaTable> luaStart;
    private Action<LuaTable> luaOnEnable;
    private Action<LuaTable> luaOnDisable;
    private Action<LuaTable> luaUpdate;
    private Action<LuaTable> luaOnDestroy;

    private LuaTable _luaInstance;
    private static StringReturnTable creatorFunc;

    public LuaTable luaInstance
    {
        get
        { return _luaInstance; }
    }

    void Awake()
    {
        if (creatorFunc == null)
        {
            // function in lua
            creatorFunc = XLuaComponent.instance.luaEnv.Global.Get<StringReturnTable>("NewLuaInstanceByPath");
        }

        _luaInstance = creatorFunc(LuaFilePath);
        
        _luaInstance.Set("parent", this);
        _luaInstance.Set("gameObject", gameObject);
        _luaInstance.Set("transform", transform);

        for (int i = 0; i < injections.Length; i++)
        {
            if (injections[i].name == "parent" || injections[i].name == "gameObject" || injections[i].name == "transform")
            {
                Debug.LogError(gameObject.name + "'s lua injections include " + injections[i].name);
            }
            else
            {
                _luaInstance.Set(injections[i].name, injections[i].value);
            }
        }

        Action<LuaTable> luaAwake = _luaInstance.Get<Action<LuaTable>>("Awake");
        _luaInstance.Get("Start", out luaStart);
        _luaInstance.Get("OnEnable", out luaOnEnable);
        _luaInstance.Get("OnDisable", out luaOnDisable);
        _luaInstance.Get("Update", out luaUpdate);
        _luaInstance.Get("OnDestroy", out luaOnDestroy);

        if (luaAwake != null)
        {
            luaAwake(luaInstance);
        }
    }

    void Start()
    {
        if (luaStart != null)
        {
            luaStart(luaInstance);
        }
    }

    void OnEnable()
    {
        if (luaOnEnable != null)
        {
            luaOnEnable(luaInstance);
        }
    }

    void OnDisable()
    {
        if (luaOnDisable != null)
        {
            luaOnDisable(luaInstance);
        }
    }

    void Update()
    {
        if (luaUpdate != null)
        {
            luaUpdate(luaInstance);
        }
    }

    void OnDestroy()
    {
        if (luaOnDestroy != null)
        {
            luaOnDestroy(luaInstance);
        }
        luaOnDestroy = null;
        luaUpdate = null;
        luaStart = null;
        _luaInstance.Dispose();
        injections = null;
    }
}