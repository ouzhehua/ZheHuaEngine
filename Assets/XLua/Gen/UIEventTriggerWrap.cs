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
    public class UIEventTriggerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UIEventTrigger), L, translator, 0, 0, 15, 13);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "dragDelta", _g_get_dragDelta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isColliderEnabled", _g_get_isColliderEnabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onHoverOver", _g_get_onHoverOver);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onHoverOut", _g_get_onHoverOut);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onPress", _g_get_onPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onRelease", _g_get_onRelease);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onSelect", _g_get_onSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDeselect", _g_get_onDeselect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClick", _g_get_onClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDoubleClick", _g_get_onDoubleClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragStart", _g_get_onDragStart);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragEnd", _g_get_onDragEnd);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragOver", _g_get_onDragOver);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDragOut", _g_get_onDragOut);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onDrag", _g_get_onDrag);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "onHoverOver", _s_set_onHoverOver);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onHoverOut", _s_set_onHoverOut);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onPress", _s_set_onPress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onRelease", _s_set_onRelease);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onSelect", _s_set_onSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDeselect", _s_set_onDeselect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onClick", _s_set_onClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDoubleClick", _s_set_onDoubleClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragStart", _s_set_onDragStart);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragEnd", _s_set_onDragEnd);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragOver", _s_set_onDragOver);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDragOut", _s_set_onDragOut);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onDrag", _s_set_onDrag);
            
			Utils.EndObjectRegister(typeof(UIEventTrigger), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UIEventTrigger), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UIEventTrigger));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "current", _s_set_current);
            
			Utils.EndClassRegister(typeof(UIEventTrigger), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UIEventTrigger __cl_gen_ret = new UIEventTrigger();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UIEventTrigger constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dragDelta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.dragDelta);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isColliderEnabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isColliderEnabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UIEventTrigger.current);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onHoverOver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onHoverOver);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onHoverOut(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onHoverOut);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onPress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onRelease(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onRelease);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onSelect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onSelect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDeselect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDeselect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDoubleClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDoubleClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragStart(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragStart);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragEnd(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragEnd);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragOver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragOver);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDragOut(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDragOut);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onDrag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onDrag);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UIEventTrigger.current = (UIEventTrigger)translator.GetObject(L, 1, typeof(UIEventTrigger));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onHoverOver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onHoverOver = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onHoverOut(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onHoverOut = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onPress = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onRelease(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onRelease = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onSelect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onSelect = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDeselect(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDeselect = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onClick = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDoubleClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDoubleClick = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragStart(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragStart = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragEnd(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragEnd = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragOver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragOver = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDragOut(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDragOut = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onDrag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UIEventTrigger __cl_gen_to_be_invoked = (UIEventTrigger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onDrag = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
