using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;

[LuaCallCSharp]
public class LuaBehaviour : MonoBehaviour
{
    public string luaFilePath;
    public GameObject[] parameters;
    public Action initializeCallBack;

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

    bool hasInited = false;
    public void Initialize()
    {
        if (hasInited)
        {
            return;
        }
        hasInited = true;

        if (creatorFunc == null)
        {
            // function in lua
            creatorFunc = XLuaComponent.instance.luaEnv.Global.Get<StringReturnTable>("NewLuaInstanceByPath");
        }
        
        _luaInstance = creatorFunc(luaFilePath);

        _luaInstance.Set("parent", this);
        _luaInstance.Set("gameObject", gameObject);
        _luaInstance.Set("transform", transform);

        for (int i = 0; i < parameters.Length; i++)
        {
            if (parameters[i].name == "parent" || parameters[i].name == "gameObject" || parameters[i].name == "transform")
            {
                Debug.LogError(gameObject.name + "'s lua injections include " + parameters[i].name);
            }
            else
            {
                _luaInstance.Set(parameters[i].name, parameters[i]);
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

        if (initializeCallBack != null)
        {
            initializeCallBack();
        }
    }

    void Awake()
    {
        if (string.IsNullOrEmpty(luaFilePath))
        {
            return;
        }

        Initialize();
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
        parameters = null;
    }
}