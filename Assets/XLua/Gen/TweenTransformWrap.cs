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
    public class TweenTransformWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(TweenTransform), L, translator, 0, 0, 3, 3);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "from", _g_get_from);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "to", _g_get_to);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parentWhenFinished", _g_get_parentWhenFinished);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "from", _s_set_from);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "to", _s_set_to);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "parentWhenFinished", _s_set_parentWhenFinished);
            
			Utils.EndObjectRegister(typeof(TweenTransform), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(TweenTransform), L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Begin", _m_Begin_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(TweenTransform));
			
			
			Utils.EndClassRegister(typeof(TweenTransform), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					TweenTransform __cl_gen_ret = new TweenTransform();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to TweenTransform constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Begin_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    float duration = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Transform to = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    
                        TweenTransform __cl_gen_ret = TweenTransform.Begin( go, duration, to );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)&& translator.Assignable<UnityEngine.Transform>(L, 4)) 
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    float duration = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Transform from = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    UnityEngine.Transform to = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                        TweenTransform __cl_gen_ret = TweenTransform.Begin( go, duration, from, to );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to TweenTransform.Begin!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_from(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenTransform __cl_gen_to_be_invoked = (TweenTransform)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.from);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_to(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenTransform __cl_gen_to_be_invoked = (TweenTransform)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.to);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parentWhenFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenTransform __cl_gen_to_be_invoked = (TweenTransform)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.parentWhenFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_from(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenTransform __cl_gen_to_be_invoked = (TweenTransform)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.from = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_to(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenTransform __cl_gen_to_be_invoked = (TweenTransform)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.to = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_parentWhenFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenTransform __cl_gen_to_be_invoked = (TweenTransform)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.parentWhenFinished = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
