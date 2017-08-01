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
    public class UISpriteWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UISprite), L, translator, 0, 3, 14, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAtlasSprite", _m_GetAtlasSprite);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakePixelPerfect", _m_MakePixelPerfect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFill", _m_OnFill);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainTexture", _g_get_mainTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "atlas", _g_get_atlas);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "spriteName", _g_get_spriteName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isValid", _g_get_isValid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "applyGradient", _g_get_applyGradient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gradientTop", _g_get_gradientTop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gradientBottom", _g_get_gradientBottom);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "border", _g_get_border);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelSize", _g_get_pixelSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minWidth", _g_get_minWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minHeight", _g_get_minHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawingDimensions", _g_get_drawingDimensions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "premultipliedAlpha", _g_get_premultipliedAlpha);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "mainTexture", _s_set_mainTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "atlas", _s_set_atlas);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "spriteName", _s_set_spriteName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "applyGradient", _s_set_applyGradient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gradientTop", _s_set_gradientTop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gradientBottom", _s_set_gradientBottom);
            
			Utils.EndObjectRegister(typeof(UISprite), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UISprite), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UISprite));
			
			
			Utils.EndClassRegister(typeof(UISprite), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UISprite __cl_gen_ret = new UISprite();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UISprite constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAtlasSprite(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UISpriteData __cl_gen_ret = __cl_gen_to_be_invoked.GetAtlasSprite(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakePixelPerfect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
            
            
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
            
            
            UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
            
            
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
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
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
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.material);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_atlas(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.atlas);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spriteName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.spriteName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isValid(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isValid);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_applyGradient(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.applyGradient);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gradientTop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.gradientTop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gradientBottom(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.gradientBottom);
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
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.border);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.pixelSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.minWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.minHeight);
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
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.drawingDimensions);
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
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.premultipliedAlpha);
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
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
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
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_atlas(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.atlas = (UIAtlas)translator.GetObject(L, 2, typeof(UIAtlas));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spriteName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.spriteName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_applyGradient(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.applyGradient = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gradientTop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.gradientTop = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gradientBottom(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UISprite __cl_gen_to_be_invoked = (UISprite)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.gradientBottom = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
