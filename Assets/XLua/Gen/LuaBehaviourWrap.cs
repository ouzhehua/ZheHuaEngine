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
    public class LuaBehaviourWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(LuaBehaviour), L, translator, 0, 1, 4, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Initialize", _m_Initialize);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "luaInstance", _g_get_luaInstance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "luaFilePath", _g_get_luaFilePath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parameters", _g_get_parameters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "initializeCallBack", _g_get_initializeCallBack);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "luaFilePath", _s_set_luaFilePath);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "parameters", _s_set_parameters);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "initializeCallBack", _s_set_initializeCallBack);
            
			Utils.EndObjectRegister(typeof(LuaBehaviour), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(LuaBehaviour), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(LuaBehaviour));
			
			
			Utils.EndClassRegister(typeof(LuaBehaviour), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					LuaBehaviour __cl_gen_ret = new LuaBehaviour();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LuaBehaviour constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Initialize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Initialize(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_luaInstance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.luaInstance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_luaFilePath(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.luaFilePath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parameters(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.parameters);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_initializeCallBack(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.initializeCallBack);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_luaFilePath(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.luaFilePath = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_parameters(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.parameters = (UnityEngine.GameObject[])translator.GetObject(L, 2, typeof(UnityEngine.GameObject[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_initializeCallBack(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                LuaBehaviour __cl_gen_to_be_invoked = (LuaBehaviour)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.initializeCallBack = translator.GetDelegate<System.Action>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
