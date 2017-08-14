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
using DG.Tweening;

namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Component), L, translator, 0, 22, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponent", _m_GetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInChildren", _m_GetComponentInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInChildren", _m_GetComponentsInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInParent", _m_GetComponentInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInParent", _m_GetComponentsInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponents", _m_GetComponents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTag", _m_CompareTag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessageUpwards", _m_SendMessageUpwards);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessage", _m_SendMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BroadcastMessage", _m_BroadcastMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOComplete", _m_DOComplete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOKill", _m_DOKill);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOFlip", _m_DOFlip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOGoto", _m_DOGoto);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOPause", _m_DOPause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOPlay", _m_DOPlay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOPlayBackwards", _m_DOPlayBackwards);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOPlayForward", _m_DOPlayForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DORestart", _m_DORestart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DORewind", _m_DORewind);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOSmoothRewind", _m_DOSmoothRewind);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DOTogglePause", _m_DOTogglePause);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "transform", _g_get_transform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameObject", _g_get_gameObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tag", _g_get_tag);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "tag", _s_set_tag);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Component), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Component), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Component));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Component), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Component __cl_gen_ret = new UnityEngine.Component();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponent( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string type = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponent( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentInChildren(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentInChildren( t );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentInChildren( t, includeInactive );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentInChildren!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentsInChildren(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentsInChildren( t );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentsInChildren( t, includeInactive );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentsInChildren!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentInParent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Type t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentInParent( t );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentsInParent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentsInParent( t );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type t = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentsInParent( t, includeInactive );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentsInParent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponents(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponents( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Component>>(L, 3)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Collections.Generic.List<UnityEngine.Component> results = (System.Collections.Generic.List<UnityEngine.Component>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Component>));
                    
                    __cl_gen_to_be_invoked.GetComponents( type, results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponents!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTag(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string tag = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.CompareTag( tag );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendMessageUpwards(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.SendMessageUpwards( methodName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object value = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.SendMessageUpwards( methodName, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions options;translator.Get(L, 3, out options);
                    
                    __cl_gen_to_be_invoked.SendMessageUpwards( methodName, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object value = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions options;translator.Get(L, 4, out options);
                    
                    __cl_gen_to_be_invoked.SendMessageUpwards( methodName, value, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.SendMessageUpwards!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendMessage(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.SendMessage( methodName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object value = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.SendMessage( methodName, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions options;translator.Get(L, 3, out options);
                    
                    __cl_gen_to_be_invoked.SendMessage( methodName, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object value = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions options;translator.Get(L, 4, out options);
                    
                    __cl_gen_to_be_invoked.SendMessage( methodName, value, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.SendMessage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BroadcastMessage(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.BroadcastMessage( methodName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object parameter = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.BroadcastMessage( methodName, parameter );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions options;translator.Get(L, 3, out options);
                    
                    __cl_gen_to_be_invoked.BroadcastMessage( methodName, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object parameter = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions options;translator.Get(L, 4, out options);
                    
                    __cl_gen_to_be_invoked.BroadcastMessage( methodName, parameter, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.BroadcastMessage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOComplete(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withCallbacks = LuaAPI.lua_toboolean(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOComplete( withCallbacks );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1) 
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOComplete(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.DOComplete!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOKill(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool complete = LuaAPI.lua_toboolean(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOKill( complete );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1) 
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOKill(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.DOKill!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOFlip(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOFlip(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOGoto(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    float to = (float)LuaAPI.lua_tonumber(L, 2);
                    bool andPlay = LuaAPI.lua_toboolean(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOGoto( to, andPlay );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float to = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOGoto( to );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.DOGoto!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOPause(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOPause(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOPlay(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOPlay(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOPlayBackwards(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOPlayBackwards(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOPlayForward(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOPlayForward(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DORestart(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool includeDelay = LuaAPI.lua_toboolean(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DORestart( includeDelay );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1) 
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DORestart(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.DORestart!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DORewind(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool includeDelay = LuaAPI.lua_toboolean(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DORewind( includeDelay );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1) 
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DORewind(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Component.DORewind!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOSmoothRewind(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOSmoothRewind(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DOTogglePause(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.DOTogglePause(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.transform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gameObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.gameObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.tag);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Component __cl_gen_to_be_invoked = (UnityEngine.Component)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.tag = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
