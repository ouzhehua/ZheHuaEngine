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
    public class UITweenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UITweener), L, translator, 0, 11, 15, 13);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetOnFinished", _m_SetOnFinished);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddOnFinished", _m_AddOnFinished);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveOnFinished", _m_RemoveOnFinished);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Sample", _m_Sample);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PlayForward", _m_PlayForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PlayReverse", _m_PlayReverse);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetToBeginning", _m_ResetToBeginning);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Toggle", _m_Toggle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetStartToCurrentValue", _m_SetStartToCurrentValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetEndToCurrentValue", _m_SetEndToCurrentValue);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "amountPerDelta", _g_get_amountPerDelta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tweenFactor", _g_get_tweenFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "direction", _g_get_direction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "method", _g_get_method);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "style", _g_get_style);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animationCurve", _g_get_animationCurve);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ignoreTimeScale", _g_get_ignoreTimeScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "delay", _g_get_delay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "duration", _g_get_duration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "steeperCurves", _g_get_steeperCurves);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tweenGroup", _g_get_tweenGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useFixedUpdate", _g_get_useFixedUpdate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFinished", _g_get_onFinished);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventReceiver", _g_get_eventReceiver);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "callWhenFinished", _g_get_callWhenFinished);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "tweenFactor", _s_set_tweenFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "method", _s_set_method);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "style", _s_set_style);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "animationCurve", _s_set_animationCurve);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ignoreTimeScale", _s_set_ignoreTimeScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "delay", _s_set_delay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "duration", _s_set_duration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "steeperCurves", _s_set_steeperCurves);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tweenGroup", _s_set_tweenGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useFixedUpdate", _s_set_useFixedUpdate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onFinished", _s_set_onFinished);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eventReceiver", _s_set_eventReceiver);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "callWhenFinished", _s_set_callWhenFinished);
            
			Utils.EndObjectRegister(typeof(UITweener), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UITweener), L, __CreateInstance, 1, 1, 1);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UITweener));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "current", _g_get_current);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "current", _s_set_current);
            
			Utils.EndClassRegister(typeof(UITweener), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UITweener does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetOnFinished(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<EventDelegate.Callback>(L, 2)) 
                {
                    EventDelegate.Callback del = translator.GetDelegate<EventDelegate.Callback>(L, 2);
                    
                    __cl_gen_to_be_invoked.SetOnFinished( del );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<EventDelegate>(L, 2)) 
                {
                    EventDelegate del = (EventDelegate)translator.GetObject(L, 2, typeof(EventDelegate));
                    
                    __cl_gen_to_be_invoked.SetOnFinished( del );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UITweener.SetOnFinished!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddOnFinished(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<EventDelegate.Callback>(L, 2)) 
                {
                    EventDelegate.Callback del = translator.GetDelegate<EventDelegate.Callback>(L, 2);
                    
                    __cl_gen_to_be_invoked.AddOnFinished( del );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<EventDelegate>(L, 2)) 
                {
                    EventDelegate del = (EventDelegate)translator.GetObject(L, 2, typeof(EventDelegate));
                    
                    __cl_gen_to_be_invoked.AddOnFinished( del );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UITweener.AddOnFinished!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveOnFinished(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    EventDelegate del = (EventDelegate)translator.GetObject(L, 2, typeof(EventDelegate));
                    
                    __cl_gen_to_be_invoked.RemoveOnFinished( del );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Sample(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float factor = (float)LuaAPI.lua_tonumber(L, 2);
                    bool isFinished = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.Sample( factor, isFinished );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayForward(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.PlayForward(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayReverse(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.PlayReverse(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_ResetToBeginning(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ResetToBeginning(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Toggle(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Toggle(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStartToCurrentValue(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetStartToCurrentValue(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetEndToCurrentValue(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetEndToCurrentValue(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_amountPerDelta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.amountPerDelta);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tweenFactor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.tweenFactor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_direction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.direction);
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
			    translator.Push(L, UITweener.current);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_method(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.method);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_style(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.style);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animationCurve(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.animationCurve);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ignoreTimeScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.ignoreTimeScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_delay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.delay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_duration(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.duration);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_steeperCurves(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.steeperCurves);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tweenGroup(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.tweenGroup);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useFixedUpdate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useFixedUpdate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventReceiver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.eventReceiver);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_callWhenFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.callWhenFinished);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tweenFactor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.tweenFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_current(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UITweener.current = (UITweener)translator.GetObject(L, 1, typeof(UITweener));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_method(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                UITweener.Method __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.method = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_style(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                UITweener.Style __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.style = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_animationCurve(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.animationCurve = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ignoreTimeScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ignoreTimeScale = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_delay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.delay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_duration(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.duration = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_steeperCurves(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.steeperCurves = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tweenGroup(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.tweenGroup = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useFixedUpdate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useFixedUpdate = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onFinished = (System.Collections.Generic.List<EventDelegate>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<EventDelegate>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eventReceiver(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.eventReceiver = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_callWhenFinished(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UITweener __cl_gen_to_be_invoked = (UITweener)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.callWhenFinished = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
