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
    public class DGTweeningTweenSettingsExtensionsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(DG.Tweening.TweenSettingsExtensions), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(DG.Tweening.TweenSettingsExtensions), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(DG.Tweening.TweenSettingsExtensions), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(DG.Tweening.TweenSettingsExtensions));
			
			
			Utils.EndClassRegister(typeof(DG.Tweening.TweenSettingsExtensions), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DG.Tweening.TweenSettingsExtensions does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
