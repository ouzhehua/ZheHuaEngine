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
    public class UITextureWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UITexture), L, translator, 0, 2, 8, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakePixelPerfect", _m_MakePixelPerfect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFill", _m_OnFill);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainTexture", _g_get_mainTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shader", _g_get_shader);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "premultipliedAlpha", _g_get_premultipliedAlpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "border", _g_get_border);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uvRect", _g_get_uvRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawingDimensions", _g_get_drawingDimensions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fixedAspect", _g_get_fixedAspect);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "mainTexture", _s_set_mainTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shader", _s_set_shader);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "border", _s_set_border);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uvRect", _s_set_uvRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fixedAspect", _s_set_fixedAspect);
            
			Utils.EndObjectRegister(typeof(UITexture), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UITexture), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UITexture));
			
			
			Utils.EndClassRegister(typeof(UITexture), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UITexture __cl_gen_ret = new UITexture();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UITexture constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakePixelPerfect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.MakePixelPerfect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFill(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> verts = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector2> uvs = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Color> cols = (System.Collections.Generic.List<UnityEngine.Color>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Color>));
                    
                    __cl_gen_to_be_invoked.OnFill( verts, uvs, cols );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mainTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.material);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shader(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.shader);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_premultipliedAlpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.premultipliedAlpha);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_border(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.border);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uvRect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.uvRect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawingDimensions(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.drawingDimensions);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fixedAspect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.fixedAspect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mainTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mainTexture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shader(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.shader = (UnityEngine.Shader)translator.GetObject(L, 2, typeof(UnityEngine.Shader));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_border(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.border = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uvRect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                UnityEngine.Rect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.uvRect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fixedAspect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITexture __cl_gen_to_be_invoked = (UITexture)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fixedAspect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
