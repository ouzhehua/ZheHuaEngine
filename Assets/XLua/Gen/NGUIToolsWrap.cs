#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class NGUIToolsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(NGUITools), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(NGUITools), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(NGUITools), L, __CreateInstance, 39, 6, 4);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PlaySound", _m_PlaySound_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RandomRange", _m_RandomRange_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetHierarchy", _m_GetHierarchy_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindCameraForLayer", _m_FindCameraForLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddWidgetCollider", _m_AddWidgetCollider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateWidgetCollider", _m_UpdateWidgetCollider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTypeName", _m_GetTypeName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterUndo", _m_RegisterUndo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetDirty", _m_SetDirty_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddChild", _m_AddChild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateRaycastDepth", _m_CalculateRaycastDepth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateNextDepth", _m_CalculateNextDepth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AdjustDepth", _m_AdjustDepth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BringForward", _m_BringForward_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PushBack", _m_PushBack_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NormalizeDepths", _m_NormalizeDepths_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NormalizeWidgetDepths", _m_NormalizeWidgetDepths_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NormalizePanelDepths", _m_NormalizePanelDepths_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateUI", _m_CreateUI_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRoot", _m_GetRoot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Destroy", _m_Destroy_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DestroyImmediate", _m_DestroyImmediate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Broadcast", _m_Broadcast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsChild", _m_IsChild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetActive", _m_SetActive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetActiveChildren", _m_SetActiveChildren_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetActive", _m_GetActive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetActiveSelf", _m_SetActiveSelf_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLayer", _m_SetLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Round", _m_Round_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MakePixelPerfect", _m_MakePixelPerfect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Save", _m_Save_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Load", _m_Load_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ApplyPMA", _m_ApplyPMA_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MarkParentAsChanged", _m_MarkParentAsChanged_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFuncName", _m_GetFuncName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ImmediatelyCreateDrawCalls", _m_ImmediatelyCreateDrawCalls_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KeyToCaption", _m_KeyToCaption_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(NGUITools));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "soundVolume", _g_get_soundVolume);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fileAccess", _g_get_fileAccess);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "clipboard", _g_get_clipboard);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "screenSize", _g_get_screenSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "audioSource", _g_get_audioSource);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "keys", _g_get_keys);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "soundVolume", _s_set_soundVolume);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "clipboard", _s_set_clipboard);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "audioSource", _s_set_audioSource);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "keys", _s_set_keys);
            
			Utils.EndClassRegister(typeof(NGUITools), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "NGUITools does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlaySound_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.AudioClip>(L, 1)) 
                {
                    UnityEngine.AudioClip clip = (UnityEngine.AudioClip)translator.GetObject(L, 1, typeof(UnityEngine.AudioClip));
                    
                        UnityEngine.AudioSource __cl_gen_ret = NGUITools.PlaySound( clip );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.AudioClip>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.AudioClip clip = (UnityEngine.AudioClip)translator.GetObject(L, 1, typeof(UnityEngine.AudioClip));
                    float volume = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.AudioSource __cl_gen_ret = NGUITools.PlaySound( clip, volume );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.AudioClip>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.AudioClip clip = (UnityEngine.AudioClip)translator.GetObject(L, 1, typeof(UnityEngine.AudioClip));
                    float volume = (float)LuaAPI.lua_tonumber(L, 2);
                    float pitch = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.AudioSource __cl_gen_ret = NGUITools.PlaySound( clip, volume, pitch );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.PlaySound!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RandomRange_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int min = LuaAPI.xlua_tointeger(L, 1);
                    int max = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = NGUITools.RandomRange( min, max );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHierarchy_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject obj = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        string __cl_gen_ret = NGUITools.GetHierarchy( obj );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindCameraForLayer_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int layer = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Camera __cl_gen_ret = NGUITools.FindCameraForLayer( layer );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddWidgetCollider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    NGUITools.AddWidgetCollider( go );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    bool considerInactive = LuaAPI.lua_toboolean(L, 2);
                    
                    NGUITools.AddWidgetCollider( go, considerInactive );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.AddWidgetCollider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateWidgetCollider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    NGUITools.UpdateWidgetCollider( go );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    bool considerInactive = LuaAPI.lua_toboolean(L, 2);
                    
                    NGUITools.UpdateWidgetCollider( go, considerInactive );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.BoxCollider>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.BoxCollider box = (UnityEngine.BoxCollider)translator.GetObject(L, 1, typeof(UnityEngine.BoxCollider));
                    bool considerInactive = LuaAPI.lua_toboolean(L, 2);
                    
                    NGUITools.UpdateWidgetCollider( box, considerInactive );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.BoxCollider2D>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.BoxCollider2D box = (UnityEngine.BoxCollider2D)translator.GetObject(L, 1, typeof(UnityEngine.BoxCollider2D));
                    bool considerInactive = LuaAPI.lua_toboolean(L, 2);
                    
                    NGUITools.UpdateWidgetCollider( box, considerInactive );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.UpdateWidgetCollider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeName_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        string __cl_gen_ret = NGUITools.GetTypeName( obj );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterUndo_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                    NGUITools.RegisterUndo( obj, name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDirty_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    NGUITools.SetDirty( obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddChild_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject parent = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        UnityEngine.GameObject __cl_gen_ret = NGUITools.AddChild( parent );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateRaycastDepth_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        int __cl_gen_ret = NGUITools.CalculateRaycastDepth( go );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateNextDepth_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        int __cl_gen_ret = NGUITools.CalculateNextDepth( go );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    bool ignoreChildrenWithColliders = LuaAPI.lua_toboolean(L, 2);
                    
                        int __cl_gen_ret = NGUITools.CalculateNextDepth( go, ignoreChildrenWithColliders );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.CalculateNextDepth!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AdjustDepth_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    int adjustment = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = NGUITools.AdjustDepth( go, adjustment );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BringForward_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    NGUITools.BringForward( go );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushBack_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    NGUITools.PushBack( go );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NormalizeDepths_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    NGUITools.NormalizeDepths(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NormalizeWidgetDepths_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 0) 
                {
                    
                    NGUITools.NormalizeWidgetDepths(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    NGUITools.NormalizeWidgetDepths( go );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& translator.Assignable<UIWidget[]>(L, 1)) 
                {
                    UIWidget[] list = (UIWidget[])translator.GetObject(L, 1, typeof(UIWidget[]));
                    
                    NGUITools.NormalizeWidgetDepths( list );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.NormalizeWidgetDepths!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NormalizePanelDepths_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    NGUITools.NormalizePanelDepths(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateUI_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool advanced3D = LuaAPI.lua_toboolean(L, 1);
                    
                        UIPanel __cl_gen_ret = NGUITools.CreateUI( advanced3D );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    bool advanced3D = LuaAPI.lua_toboolean(L, 1);
                    int layer = LuaAPI.xlua_tointeger(L, 2);
                    
                        UIPanel __cl_gen_ret = NGUITools.CreateUI( advanced3D, layer );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    bool advanced3D = LuaAPI.lua_toboolean(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    
                        UIPanel __cl_gen_ret = NGUITools.CreateUI( trans, advanced3D, layer );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.CreateUI!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRoot_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        UnityEngine.GameObject __cl_gen_ret = NGUITools.GetRoot( go );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Destroy_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    NGUITools.Destroy( obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyImmediate_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    NGUITools.DestroyImmediate( obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Broadcast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string funcName = LuaAPI.lua_tostring(L, 1);
                    
                    NGUITools.Broadcast( funcName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)) 
                {
                    string funcName = LuaAPI.lua_tostring(L, 1);
                    object param = translator.GetObject(L, 2, typeof(object));
                    
                    NGUITools.Broadcast( funcName, param );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.Broadcast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsChild_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform child = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        bool __cl_gen_ret = NGUITools.IsChild( parent, child );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetActive_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    bool state = LuaAPI.lua_toboolean(L, 2);
                    
                    NGUITools.SetActive( go, state );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    bool state = LuaAPI.lua_toboolean(L, 2);
                    bool compatibilityMode = LuaAPI.lua_toboolean(L, 3);
                    
                    NGUITools.SetActive( go, state, compatibilityMode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.SetActive!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetActiveChildren_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    bool state = LuaAPI.lua_toboolean(L, 2);
                    
                    NGUITools.SetActiveChildren( go, state );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetActive_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Behaviour>(L, 1)) 
                {
                    UnityEngine.Behaviour mb = (UnityEngine.Behaviour)translator.GetObject(L, 1, typeof(UnityEngine.Behaviour));
                    
                        bool __cl_gen_ret = NGUITools.GetActive( mb );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.GameObject>(L, 1)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                        bool __cl_gen_ret = NGUITools.GetActive( go );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to NGUITools.GetActive!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetActiveSelf_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    bool state = LuaAPI.lua_toboolean(L, 2);
                    
                    NGUITools.SetActiveSelf( go, state );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLayer_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    int layer = LuaAPI.xlua_tointeger(L, 2);
                    
                    NGUITools.SetLayer( go, layer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Round_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 v;translator.Get(L, 1, out v);
                    
                        UnityEngine.Vector3 __cl_gen_ret = NGUITools.Round( v );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakePixelPerfect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform t = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                    NGUITools.MakePixelPerfect( t );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Save_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string fileName = LuaAPI.lua_tostring(L, 1);
                    byte[] bytes = LuaAPI.lua_tobytes(L, 2);
                    
                        bool __cl_gen_ret = NGUITools.Save( fileName, bytes );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string fileName = LuaAPI.lua_tostring(L, 1);
                    
                        byte[] __cl_gen_ret = NGUITools.Load( fileName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyPMA_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Color c;translator.Get(L, 1, out c);
                    
                        UnityEngine.Color __cl_gen_ret = NGUITools.ApplyPMA( c );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MarkParentAsChanged_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    NGUITools.MarkParentAsChanged( go );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFuncName_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    object obj = translator.GetObject(L, 1, typeof(object));
                    string method = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = NGUITools.GetFuncName( obj, method );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ImmediatelyCreateDrawCalls_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.GameObject root = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    
                    NGUITools.ImmediatelyCreateDrawCalls( root );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KeyToCaption_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.KeyCode key;translator.Get(L, 1, out key);
                    
                        string __cl_gen_ret = NGUITools.KeyToCaption( key );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_soundVolume(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, NGUITools.soundVolume);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fileAccess(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, NGUITools.fileAccess);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clipboard(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, NGUITools.clipboard);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_screenSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineVector2(L, NGUITools.screenSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_audioSource(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, NGUITools.audioSource);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keys(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, NGUITools.keys);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_soundVolume(RealStatePtr L)
        {
            
            try {
			    NGUITools.soundVolume = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clipboard(RealStatePtr L)
        {
            
            try {
			    NGUITools.clipboard = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_audioSource(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    NGUITools.audioSource = (UnityEngine.AudioSource)translator.GetObject(L, 1, typeof(UnityEngine.AudioSource));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keys(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    NGUITools.keys = (UnityEngine.KeyCode[])translator.GetObject(L, 1, typeof(UnityEngine.KeyCode[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
