using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using XLua;

public class LuaUIForm : UIFormBase
{
    public string luaFilePath;
    public Injection[] injections;

    private LuaBehaviour luaBehaviour;
    void Awake()
    {
        luaBehaviour = gameObject.AddComponent<LuaBehaviour>();
        luaBehaviour.luaFilePath = luaFilePath;
        luaBehaviour.injections = injections;
        luaBehaviour.initializeCallBack = InitializeCallBack;

        luaBehaviour.Initialize();
    }

    void InitializeCallBack()
    {
        luaBehaviour.luaInstance.Get("OnInit", out onInit);
        luaBehaviour.luaInstance.Get("OnOpen", out onOpen);
        luaBehaviour.luaInstance.Get("OnClose", out onClose);
    }

    private Action<LuaTable, object> onInit;
    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        if (onInit != null)
        {
            onInit(luaBehaviour.luaInstance, userData);
        }
    }
    private Action<LuaTable, object> onOpen;
    protected internal override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        if (onOpen != null)
        {
            onOpen(luaBehaviour.luaInstance, userData);
        }
    }
    private Action<LuaTable, object> onClose;
    protected internal override void OnClose(object userData)
    {
        base.OnClose(userData);
        if (onClose != null)
        {
            onClose(luaBehaviour.luaInstance, userData);
        }
    }

    //protected internal override void OnPause()
    //{
    //    base.OnPause();
    //}
    //protected internal override void OnResume()
    //{
    //    base.OnResume();
    //}
    //protected internal override void OnCover()
    //{
    //    base.OnCover();
    //}
    //protected internal override void OnReveal()
    //{
    //    base.OnReveal();
    //}
    //protected internal override void OnRefocus(object userData)
    //{
    //    base.OnRefocus(userData);
    //}
    //protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
    //{
    //    base.OnUpdate(elapseSeconds, realElapseSeconds);
    //}
    //protected internal override void OnDepthChanged(int uiGroupDepth, int depthInUIGroup)
    //{
    //    base.OnDepthChanged(uiGroupDepth, depthInUIGroup);
    //}

    void OnDestroy()
    {
        onInit = null;
        onOpen = null;
        onClose = null;
        injections = null;
        luaBehaviour = null;
    }
}
