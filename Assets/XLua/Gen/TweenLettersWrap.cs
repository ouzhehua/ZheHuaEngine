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
    public class TweenLettersWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(TweenLetters), L, translator, 0, 1, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverOver", _g_get_hoverOver);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverOut", _g_get_hoverOut);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverOver", _s_set_hoverOver);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverOut", _s_set_hoverOut);
            
			Utils.EndObjectRegister(typeof(TweenLetters), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(TweenLetters), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(TweenLetters));
			
			
			Utils.EndClassRegister(typeof(TweenLetters), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					TweenLetters __cl_gen_ret = new TweenLetters();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to TweenLetters constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            TweenLetters __cl_gen_to_be_invoked = (TweenLetters)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool forward = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Play( forward );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverOver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenLetters __cl_gen_to_be_invoked = (TweenLetters)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.hoverOver);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverOut(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenLetters __cl_gen_to_be_invoked = (TweenLetters)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.hoverOut);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverOver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenLetters __cl_gen_to_be_invoked = (TweenLetters)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hoverOver = (TweenLetters.AnimationProperties)translator.GetObject(L, 2, typeof(TweenLetters.AnimationProperties));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverOut(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                TweenLetters __cl_gen_to_be_invoked = (TweenLetters)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hoverOut = (TweenLetters.AnimationProperties)translator.GetObject(L, 2, typeof(TweenLetters.AnimationProperties));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
