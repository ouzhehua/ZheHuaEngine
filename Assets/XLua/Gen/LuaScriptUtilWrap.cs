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
    public class LuaScriptUtilWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(LuaScriptUtil), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(LuaScriptUtil), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(LuaScriptUtil), L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddLuaFunctionDelegate", _m_AddLuaFunctionDelegate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLuaFunctionDelegate", _m_SetLuaFunctionDelegate_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(LuaScriptUtil));
			
			
			Utils.EndClassRegister(typeof(LuaScriptUtil), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					LuaScriptUtil __cl_gen_ret = new LuaScriptUtil();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LuaScriptUtil constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddLuaFunctionDelegate_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Collections.Generic.List<EventDelegate> list = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<EventDelegate>));
                    XLua.LuaFunction func = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                    LuaScriptUtil.AddLuaFunctionDelegate( list, func );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLuaFunctionDelegate_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Collections.Generic.List<EventDelegate> list = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<EventDelegate>));
                    XLua.LuaFunction func = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                    LuaScriptUtil.SetLuaFunctionDelegate( list, func );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
