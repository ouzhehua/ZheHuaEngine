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
    public class UIWidgetWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIWidget), L, translator, 0, 20, 38, 25);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDimensions", _m_SetDimensions);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSides", _m_GetSides);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateFinalAlpha", _m_CalculateFinalAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Invalidate", _m_Invalidate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateCumulativeAlpha", _m_CalculateCumulativeAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetRect", _m_SetRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResizeCollider", _m_ResizeCollider);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateBounds", _m_CalculateBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDirty", _m_SetDirty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveFromPanel", _m_RemoveFromPanel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MarkAsChanged", _m_MarkAsChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreatePanel", _m_CreatePanel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CheckLayer", _m_CheckLayer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ParentHasChanged", _m_ParentHasChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateVisibility", _m_UpdateVisibility);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateTransform", _m_UpdateTransform);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateGeometry", _m_UpdateGeometry);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteToBuffers", _m_WriteToBuffers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakePixelPerfect", _m_MakePixelPerfect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFill", _m_OnFill);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "onRender", _g_get_onRender);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawRegion", _g_get_drawRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivotOffset", _g_get_pivotOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "color", _g_get_color);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alpha", _g_get_alpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isVisible", _g_get_isVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasVertices", _g_get_hasVertices);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rawPivot", _g_get_rawPivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivot", _g_get_pivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastDepth", _g_get_raycastDepth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localCorners", _g_get_localCorners);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localSize", _g_get_localSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localCenter", _g_get_localCenter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCorners", _g_get_worldCorners);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCenter", _g_get_worldCenter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawingDimensions", _g_get_drawingDimensions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainTexture", _g_get_mainTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shader", _g_get_shader);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasBoxCollider", _g_get_hasBoxCollider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minWidth", _g_get_minWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minHeight", _g_get_minHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "border", _g_get_border);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onChange", _g_get_onChange);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onPostFill", _g_get_onPostFill);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mOnRender", _g_get_mOnRender);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoResizeBoxCollider", _g_get_autoResizeBoxCollider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideIfOffScreen", _g_get_hideIfOffScreen);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keepAspectRatio", _g_get_keepAspectRatio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aspectRatio", _g_get_aspectRatio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hitCheck", _g_get_hitCheck);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "panel", _g_get_panel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "geometry", _g_get_geometry);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillGeometry", _g_get_fillGeometry);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawCall", _g_get_drawCall);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "onRender", _s_set_onRender);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawRegion", _s_set_drawRegion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "width", _s_set_width);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "height", _s_set_height);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "color", _s_set_color);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alpha", _s_set_alpha);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rawPivot", _s_set_rawPivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pivot", _s_set_pivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depth", _s_set_depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mainTexture", _s_set_mainTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shader", _s_set_shader);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "border", _s_set_border);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onChange", _s_set_onChange);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onPostFill", _s_set_onPostFill);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mOnRender", _s_set_mOnRender);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoResizeBoxCollider", _s_set_autoResizeBoxCollider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hideIfOffScreen", _s_set_hideIfOffScreen);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keepAspectRatio", _s_set_keepAspectRatio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aspectRatio", _s_set_aspectRatio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hitCheck", _s_set_hitCheck);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "panel", _s_set_panel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "geometry", _s_set_geometry);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillGeometry", _s_set_fillGeometry);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawCall", _s_set_drawCall);
            
			Utils.EndObjectRegister(typeof(UIWidget), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIWidget), L, __CreateInstance, 3, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FullCompareFunc", _m_FullCompareFunc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PanelCompareFunc", _m_PanelCompareFunc_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIWidget));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showHandlesWithMoveTool", _g_get_showHandlesWithMoveTool);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showHandles", _g_get_showHandles);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "showHandlesWithMoveTool", _s_set_showHandlesWithMoveTool);
            
			Utils.EndClassRegister(typeof(UIWidget), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIWidget __cl_gen_ret = new UIWidget();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIWidget constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDimensions(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int w = LuaAPI.xlua_tointeger(L, 2);
                    int h = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetDimensions( w, h );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSides(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Vector3[] __cl_gen_ret = __cl_gen_to_be_invoked.GetSides( relativeTo );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateFinalAlpha(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int frameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.CalculateFinalAlpha( frameID );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Invalidate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool includeChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Invalidate( includeChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateCumulativeAlpha(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int frameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.CalculateCumulativeAlpha( frameID );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float width = (float)LuaAPI.lua_tonumber(L, 4);
                    float height = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.SetRect( x, y, width, height );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResizeCollider(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResizeCollider(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FullCompareFunc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UIWidget left = (UIWidget)translator.GetObject(L, 1, typeof(UIWidget));
                    UIWidget right = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
                    
                        int __cl_gen_ret = UIWidget.FullCompareFunc( left, right );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PanelCompareFunc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UIWidget left = (UIWidget)translator.GetObject(L, 1, typeof(UIWidget));
                    UIWidget right = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
                    
                        int __cl_gen_ret = UIWidget.PanelCompareFunc( left, right );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateBounds(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                        UnityEngine.Bounds __cl_gen_ret = __cl_gen_to_be_invoked.CalculateBounds(  );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Transform relativeParent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Bounds __cl_gen_ret = __cl_gen_to_be_invoked.CalculateBounds( relativeParent );
                        translator.PushUnityEngineBounds(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIWidget.CalculateBounds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDirty(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetDirty(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveFromPanel(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RemoveFromPanel(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MarkAsChanged(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.MarkAsChanged(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreatePanel(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UIPanel __cl_gen_ret = __cl_gen_to_be_invoked.CreatePanel(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckLayer(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.CheckLayer(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParentHasChanged(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ParentHasChanged(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateVisibility(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool visibleByAlpha = LuaAPI.lua_toboolean(L, 2);
                    bool visibleByPanel = LuaAPI.lua_toboolean(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.UpdateVisibility( visibleByAlpha, visibleByPanel );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateTransform(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int frame = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.UpdateTransform( frame );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateGeometry(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int frame = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.UpdateGeometry( frame );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteToBuffers(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> v = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector2> u = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Color> c = (System.Collections.Generic.List<UnityEngine.Color>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Color>));
                    System.Collections.Generic.List<UnityEngine.Vector3> n = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> t = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> u2 = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    __cl_gen_to_be_invoked.WriteToBuffers( v, u, c, n, t, u2 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakePixelPerfect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
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
            
            
            UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
            
            
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
        static int _g_get_onRender(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onRender);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawRegion(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.drawRegion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivotOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.pivotOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_width(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.width);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_height(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.height);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_color(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.color);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.alpha);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isVisible(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isVisible);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasVertices(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasVertices);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rawPivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rawPivot);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pivot);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.depth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raycastDepth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.raycastDepth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localCorners(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.localCorners);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.localSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_localCenter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.localCenter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldCorners(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.worldCorners);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldCenter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.worldCenter);
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.drawingDimensions);
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.material);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mainTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mainTexture);
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.shader);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasBoxCollider(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasBoxCollider);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showHandlesWithMoveTool(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UIWidget.showHandlesWithMoveTool);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showHandles(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UIWidget.showHandles);
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.minHeight);
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.border);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onChange(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onChange);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPostFill(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onPostFill);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mOnRender(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mOnRender);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoResizeBoxCollider(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.autoResizeBoxCollider);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hideIfOffScreen(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hideIfOffScreen);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keepAspectRatio(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.keepAspectRatio);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aspectRatio(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.aspectRatio);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hitCheck(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.hitCheck);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_panel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.panel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_geometry(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.geometry);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fillGeometry(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.fillGeometry);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawCall(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.drawCall);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onRender(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onRender = translator.GetDelegate<UIDrawCall.OnRenderCallback>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawRegion(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.drawRegion = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_width(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.width = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_height(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.height = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_color(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.color = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alpha(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alpha = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rawPivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                UIWidget.Pivot __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.rawPivot = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pivot(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                UIWidget.Pivot __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.pivot = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.depth = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mainTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mainTexture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
            
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.shader = (UnityEngine.Shader)translator.GetObject(L, 2, typeof(UnityEngine.Shader));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showHandlesWithMoveTool(RealStatePtr L)
        {
            
            try {
			    UIWidget.showHandlesWithMoveTool = LuaAPI.lua_toboolean(L, 1);
            
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
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.border = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onChange(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onChange = translator.GetDelegate<UIWidget.OnDimensionsChanged>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPostFill(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onPostFill = translator.GetDelegate<UIWidget.OnPostFillCallback>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mOnRender(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mOnRender = translator.GetDelegate<UIDrawCall.OnRenderCallback>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoResizeBoxCollider(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.autoResizeBoxCollider = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hideIfOffScreen(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hideIfOffScreen = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keepAspectRatio(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                UIWidget.AspectRatioSource __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.keepAspectRatio = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aspectRatio(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.aspectRatio = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hitCheck(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hitCheck = translator.GetDelegate<UIWidget.HitCheck>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_panel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.panel = (UIPanel)translator.GetObject(L, 2, typeof(UIPanel));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_geometry(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.geometry = (UIGeometry)translator.GetObject(L, 2, typeof(UIGeometry));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fillGeometry(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fillGeometry = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawCall(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIWidget __cl_gen_to_be_invoked = (UIWidget)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.drawCall = (UIDrawCall)translator.GetObject(L, 2, typeof(UIDrawCall));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
