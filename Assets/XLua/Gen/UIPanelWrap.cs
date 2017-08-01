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
    public class UIPanelWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIPanel), L, translator, 0, 19, 42, 29);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSides", _m_GetSides);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Invalidate", _m_Invalidate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateFinalAlpha", _m_CalculateFinalAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetRect", _m_SetRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsVisible", _m_IsVisible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Affects", _m_Affects);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RebuildAllDrawCalls", _m_RebuildAllDrawCalls);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDirty", _m_SetDirty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ParentHasChanged", _m_ParentHasChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SortWidgets", _m_SortWidgets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FillDrawCall", _m_FillDrawCall);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindDrawCall", _m_FindDrawCall);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddWidget", _m_AddWidget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveWidget", _m_RemoveWidget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Refresh", _m_Refresh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateConstrainOffset", _m_CalculateConstrainOffset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ConstrainTargetToBounds", _m_ConstrainTargetToBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWindowSize", _m_GetWindowSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetViewSize", _m_GetViewSize);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingLayerName", _g_get_sortingLayerName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canBeAnchored", _g_get_canBeAnchored);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alpha", _g_get_alpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingOrder", _g_get_sortingOrder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "halfPixelOffset", _g_get_halfPixelOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "usedForUI", _g_get_usedForUI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawCallOffset", _g_get_drawCallOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clipping", _g_get_clipping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parentPanel", _g_get_parentPanel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clipCount", _g_get_clipCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasClipping", _g_get_hasClipping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasCumulativeClipping", _g_get_hasCumulativeClipping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clipOffset", _g_get_clipOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clipTexture", _g_get_clipTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "baseClipRegion", _g_get_baseClipRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "finalClipRegion", _g_get_finalClipRegion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clipSoftness", _g_get_clipSoftness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localCorners", _g_get_localCorners);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCorners", _g_get_worldCorners);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onGeometryUpdated", _g_get_onGeometryUpdated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "showInPanelTool", _g_get_showInPanelTool);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "generateNormals", _g_get_generateNormals);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "generateUV2", _g_get_generateUV2);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shadowMode", _g_get_shadowMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "widgetsAreStatic", _g_get_widgetsAreStatic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cullWhileDragging", _g_get_cullWhileDragging);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alwaysOnScreen", _g_get_alwaysOnScreen);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchorOffset", _g_get_anchorOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "softBorderPadding", _g_get_softBorderPadding);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderQueue", _g_get_renderQueue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingRenderQueue", _g_get_startingRenderQueue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "widgets", _g_get_widgets);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawCalls", _g_get_drawCalls);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldToLocal", _g_get_worldToLocal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawCallClipRange", _g_get_drawCallClipRange);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClipMove", _g_get_onClipMove);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCreateMaterial", _g_get_onCreateMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onCreateDrawCall", _g_get_onCreateDrawCall);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useSortingOrder", _g_get_useSortingOrder);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingLayerName", _s_set_sortingLayerName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alpha", _s_set_alpha);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depth", _s_set_depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingOrder", _s_set_sortingOrder);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clipping", _s_set_clipping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clipOffset", _s_set_clipOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clipTexture", _s_set_clipTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "baseClipRegion", _s_set_baseClipRegion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clipSoftness", _s_set_clipSoftness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onGeometryUpdated", _s_set_onGeometryUpdated);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "showInPanelTool", _s_set_showInPanelTool);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "generateNormals", _s_set_generateNormals);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "generateUV2", _s_set_generateUV2);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shadowMode", _s_set_shadowMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "widgetsAreStatic", _s_set_widgetsAreStatic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cullWhileDragging", _s_set_cullWhileDragging);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alwaysOnScreen", _s_set_alwaysOnScreen);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "anchorOffset", _s_set_anchorOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "softBorderPadding", _s_set_softBorderPadding);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderQueue", _s_set_renderQueue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingRenderQueue", _s_set_startingRenderQueue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "widgets", _s_set_widgets);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawCalls", _s_set_drawCalls);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "worldToLocal", _s_set_worldToLocal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drawCallClipRange", _s_set_drawCallClipRange);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onClipMove", _s_set_onClipMove);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCreateMaterial", _s_set_onCreateMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onCreateDrawCall", _s_set_onCreateDrawCall);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useSortingOrder", _s_set_useSortingOrder);
            
			Utils.EndObjectRegister(typeof(UIPanel), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIPanel), L, __CreateInstance, 3, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CompareFunc", _m_CompareFunc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Find", _m_Find_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIPanel));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "nextUnusedDepth", _g_get_nextUnusedDepth);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "list", _g_get_list);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "list", _s_set_list);
            
			Utils.EndClassRegister(typeof(UIPanel), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIPanel __cl_gen_ret = new UIPanel();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIPanel constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareFunc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UIPanel a = (UIPanel)translator.GetObject(L, 1, typeof(UIPanel));
                    UIPanel b = (UIPanel)translator.GetObject(L, 2, typeof(UIPanel));
                    
                        int __cl_gen_ret = UIPanel.CompareFunc( a, b );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSides(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_Invalidate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_CalculateFinalAlpha(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_SetRect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_IsVisible(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 worldPos;translator.Get(L, 2, out worldPos);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsVisible( worldPos );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UIWidget>(L, 2)) 
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsVisible( w );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)) 
                {
                    UnityEngine.Vector3 a;translator.Get(L, 2, out a);
                    UnityEngine.Vector3 b;translator.Get(L, 3, out b);
                    UnityEngine.Vector3 c;translator.Get(L, 4, out c);
                    UnityEngine.Vector3 d;translator.Get(L, 5, out d);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsVisible( a, b, c, d );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIPanel.IsVisible!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Affects(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Affects( w );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RebuildAllDrawCalls(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RebuildAllDrawCalls(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDirty(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_ParentHasChanged(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_SortWidgets(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SortWidgets(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillDrawCall(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UIDrawCall dc = (UIDrawCall)translator.GetObject(L, 2, typeof(UIDrawCall));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.FillDrawCall( dc );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindDrawCall(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
                    
                        UIDrawCall __cl_gen_ret = __cl_gen_to_be_invoked.FindDrawCall( w );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddWidget(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
                    
                    __cl_gen_to_be_invoked.AddWidget( w );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveWidget(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UIWidget w = (UIWidget)translator.GetObject(L, 2, typeof(UIWidget));
                    
                    __cl_gen_to_be_invoked.RemoveWidget( w );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Refresh(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Refresh(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateConstrainOffset(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector2 min;translator.Get(L, 2, out min);
                    UnityEngine.Vector2 max;translator.Get(L, 3, out max);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.CalculateConstrainOffset( min, max );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConstrainTargetToBounds(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool immediate = LuaAPI.lua_toboolean(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ConstrainTargetToBounds( target, immediate );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Bounds>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Transform target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Bounds targetBounds;translator.Get(L, 3, out targetBounds);
                    bool immediate = LuaAPI.lua_toboolean(L, 4);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ConstrainTargetToBounds( target, ref targetBounds, immediate );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.PushUnityEngineBounds(L, targetBounds);
                        translator.UpdateUnityEngineBounds(L, 3, targetBounds);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIPanel.ConstrainTargetToBounds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Find_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Transform>(L, 1)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        UIPanel __cl_gen_ret = UIPanel.Find( trans );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    bool createIfMissing = LuaAPI.lua_toboolean(L, 2);
                    
                        UIPanel __cl_gen_ret = UIPanel.Find( trans, createIfMissing );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform trans = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    bool createIfMissing = LuaAPI.lua_toboolean(L, 2);
                    int layer = LuaAPI.xlua_tointeger(L, 3);
                    
                        UIPanel __cl_gen_ret = UIPanel.Find( trans, createIfMissing, layer );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UIPanel.Find!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWindowSize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UnityEngine.Vector2 __cl_gen_ret = __cl_gen_to_be_invoked.GetWindowSize(  );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetViewSize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UnityEngine.Vector2 __cl_gen_ret = __cl_gen_to_be_invoked.GetViewSize(  );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortingLayerName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.sortingLayerName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_nextUnusedDepth(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UIPanel.nextUnusedDepth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canBeAnchored(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.canBeAnchored);
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
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.alpha);
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
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.depth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortingOrder(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.sortingOrder);
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
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.width);
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
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.height);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_halfPixelOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.halfPixelOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usedForUI(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.usedForUI);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawCallOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.drawCallOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clipping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.clipping);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parentPanel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.parentPanel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clipCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.clipCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasClipping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasClipping);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasCumulativeClipping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasCumulativeClipping);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clipOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.clipOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clipTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.clipTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_baseClipRegion(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.baseClipRegion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalClipRegion(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.finalClipRegion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clipSoftness(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.clipSoftness);
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
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.localCorners);
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
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.worldCorners);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_list(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UIPanel.list);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onGeometryUpdated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onGeometryUpdated);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showInPanelTool(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.showInPanelTool);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_generateNormals(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.generateNormals);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_generateUV2(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.generateUV2);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shadowMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.shadowMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_widgetsAreStatic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.widgetsAreStatic);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cullWhileDragging(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.cullWhileDragging);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alwaysOnScreen(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.alwaysOnScreen);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_anchorOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.anchorOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_softBorderPadding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.softBorderPadding);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderQueue(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.renderQueue);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingRenderQueue(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.startingRenderQueue);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_widgets(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.widgets);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawCalls(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.drawCalls);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldToLocal(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.worldToLocal);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drawCallClipRange(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.drawCallClipRange);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onClipMove(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onClipMove);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCreateMaterial(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onCreateMaterial);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCreateDrawCall(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onCreateDrawCall);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useSortingOrder(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useSortingOrder);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sortingLayerName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sortingLayerName = LuaAPI.lua_tostring(L, 2);
            
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
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alpha = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.depth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sortingOrder(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sortingOrder = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clipping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                UIDrawCall.Clipping __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.clipping = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clipOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.clipOffset = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clipTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.clipTexture = (UnityEngine.Texture2D)translator.GetObject(L, 2, typeof(UnityEngine.Texture2D));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_baseClipRegion(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.baseClipRegion = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clipSoftness(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.clipSoftness = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_list(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UIPanel.list = (System.Collections.Generic.List<UIPanel>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UIPanel>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onGeometryUpdated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onGeometryUpdated = translator.GetDelegate<UIPanel.OnGeometryUpdated>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showInPanelTool(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.showInPanelTool = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_generateNormals(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.generateNormals = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_generateUV2(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.generateUV2 = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shadowMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                UIDrawCall.ShadowMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.shadowMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_widgetsAreStatic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.widgetsAreStatic = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cullWhileDragging(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cullWhileDragging = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alwaysOnScreen(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alwaysOnScreen = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_anchorOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.anchorOffset = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_softBorderPadding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.softBorderPadding = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderQueue(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                UIPanel.RenderQueue __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.renderQueue = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingRenderQueue(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startingRenderQueue = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_widgets(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.widgets = (System.Collections.Generic.List<UIWidget>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UIWidget>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawCalls(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.drawCalls = (System.Collections.Generic.List<UIDrawCall>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UIDrawCall>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_worldToLocal(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                UnityEngine.Matrix4x4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.worldToLocal = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drawCallClipRange(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector4 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.drawCallClipRange = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onClipMove(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onClipMove = translator.GetDelegate<UIPanel.OnClippingMoved>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCreateMaterial(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onCreateMaterial = translator.GetDelegate<UIPanel.OnCreateMaterial>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCreateDrawCall(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onCreateDrawCall = translator.GetDelegate<UIDrawCall.OnCreateDrawCall>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useSortingOrder(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIPanel __cl_gen_to_be_invoked = (UIPanel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useSortingOrder = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
