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
    public class UILabelWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UILabel), L, translator, 0, 21, 44, 30);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSides", _m_GetSides);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MarkAsChanged", _m_MarkAsChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessText", _m_ProcessText);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakePixelPerfect", _m_MakePixelPerfect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AssumeNaturalSize", _m_AssumeNaturalSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCharacterIndexAtPosition", _m_GetCharacterIndexAtPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWordAtPosition", _m_GetWordAtPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWordAtCharacterIndex", _m_GetWordAtCharacterIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUrlAtPosition", _m_GetUrlAtPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUrlAtCharacterIndex", _m_GetUrlAtCharacterIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCharacterIndex", _m_GetCharacterIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PrintOverlay", _m_PrintOverlay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFill", _m_OnFill);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyOffset", _m_ApplyOffset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyShadow", _m_ApplyShadow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateOffsetToFit", _m_CalculateOffsetToFit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurrentProgress", _m_SetCurrentProgress);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurrentPercent", _m_SetCurrentPercent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurrentSelection", _m_SetCurrentSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Wrap", _m_Wrap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateNGUIText", _m_UpdateNGUIText);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "finalFontSize", _g_get_finalFontSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isAnchoredHorizontally", _g_get_isAnchoredHorizontally);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isAnchoredVertically", _g_get_isAnchoredVertically);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mainTexture", _g_get_mainTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bitmapFont", _g_get_bitmapFont);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trueTypeFont", _g_get_trueTypeFont);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ambigiousFont", _g_get_ambigiousFont);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", _g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultFontSize", _g_get_defaultFontSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontSize", _g_get_fontSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontStyle", _g_get_fontStyle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alignment", _g_get_alignment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "applyGradient", _g_get_applyGradient);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gradientTop", _g_get_gradientTop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gradientBottom", _g_get_gradientBottom);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "spacingX", _g_get_spacingX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "spacingY", _g_get_spacingY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useFloatSpacing", _g_get_useFloatSpacing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "floatSpacingX", _g_get_floatSpacingX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "floatSpacingY", _g_get_floatSpacingY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "effectiveSpacingY", _g_get_effectiveSpacingY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "effectiveSpacingX", _g_get_effectiveSpacingX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overflowEllipsis", _g_get_overflowEllipsis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overflowWidth", _g_get_overflowWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "supportEncoding", _g_get_supportEncoding);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "symbolStyle", _g_get_symbolStyle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overflowMethod", _g_get_overflowMethod);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "multiLine", _g_get_multiLine);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localCorners", _g_get_localCorners);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCorners", _g_get_worldCorners);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drawingDimensions", _g_get_drawingDimensions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxLineCount", _g_get_maxLineCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "effectStyle", _g_get_effectStyle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "effectColor", _g_get_effectColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "effectDistance", _g_get_effectDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "quadsPerCharacter", _g_get_quadsPerCharacter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "processedText", _g_get_processedText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "printedSize", _g_get_printedSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localSize", _g_get_localSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "modifier", _g_get_modifier);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "printedText", _g_get_printedText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keepCrispWhenShrunk", _g_get_keepCrispWhenShrunk);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customModifier", _g_get_customModifier);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mainTexture", _s_set_mainTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bitmapFont", _s_set_bitmapFont);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trueTypeFont", _s_set_trueTypeFont);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ambigiousFont", _s_set_ambigiousFont);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "text", _s_set_text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fontSize", _s_set_fontSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fontStyle", _s_set_fontStyle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alignment", _s_set_alignment);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "applyGradient", _s_set_applyGradient);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gradientTop", _s_set_gradientTop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gradientBottom", _s_set_gradientBottom);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "spacingX", _s_set_spacingX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "spacingY", _s_set_spacingY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useFloatSpacing", _s_set_useFloatSpacing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "floatSpacingX", _s_set_floatSpacingX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "floatSpacingY", _s_set_floatSpacingY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overflowEllipsis", _s_set_overflowEllipsis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overflowWidth", _s_set_overflowWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "supportEncoding", _s_set_supportEncoding);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "symbolStyle", _s_set_symbolStyle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overflowMethod", _s_set_overflowMethod);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "multiLine", _s_set_multiLine);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxLineCount", _s_set_maxLineCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "effectStyle", _s_set_effectStyle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "effectColor", _s_set_effectColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "effectDistance", _s_set_effectDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "modifier", _s_set_modifier);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keepCrispWhenShrunk", _s_set_keepCrispWhenShrunk);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "customModifier", _s_set_customModifier);
            
			Utils.EndObjectRegister(typeof(UILabel), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UILabel), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UILabel));
			
			
			Utils.EndClassRegister(typeof(UILabel), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UILabel __cl_gen_ret = new UILabel();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UILabel constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSides(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_MarkAsChanged(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_ProcessText(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool legacyMode = LuaAPI.lua_toboolean(L, 2);
                    bool full = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.ProcessText( legacyMode, full );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool legacyMode = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.ProcessText( legacyMode );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.ProcessText(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UILabel.ProcessText!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakePixelPerfect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_AssumeNaturalSize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.AssumeNaturalSize(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCharacterIndexAtPosition(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 worldPos;translator.Get(L, 2, out worldPos);
                    bool precise = LuaAPI.lua_toboolean(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetCharacterIndexAtPosition( worldPos, precise );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 localPos;translator.Get(L, 2, out localPos);
                    bool precise = LuaAPI.lua_toboolean(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetCharacterIndexAtPosition( localPos, precise );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UILabel.GetCharacterIndexAtPosition!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWordAtPosition(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 worldPos;translator.Get(L, 2, out worldPos);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetWordAtPosition( worldPos );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 localPos;translator.Get(L, 2, out localPos);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetWordAtPosition( localPos );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UILabel.GetWordAtPosition!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWordAtCharacterIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int characterIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetWordAtCharacterIndex( characterIndex );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUrlAtPosition(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 worldPos;translator.Get(L, 2, out worldPos);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetUrlAtPosition( worldPos );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 localPos;translator.Get(L, 2, out localPos);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetUrlAtPosition( localPos );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UILabel.GetUrlAtPosition!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUrlAtCharacterIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int characterIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetUrlAtCharacterIndex( characterIndex );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCharacterIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int currentIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.KeyCode key;translator.Get(L, 3, out key);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetCharacterIndex( currentIndex, key );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PrintOverlay(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int start = LuaAPI.xlua_tointeger(L, 2);
                    int end = LuaAPI.xlua_tointeger(L, 3);
                    UIGeometry caret = (UIGeometry)translator.GetObject(L, 4, typeof(UIGeometry));
                    UIGeometry highlight = (UIGeometry)translator.GetObject(L, 5, typeof(UIGeometry));
                    UnityEngine.Color caretColor;translator.Get(L, 6, out caretColor);
                    UnityEngine.Color highlightColor;translator.Get(L, 7, out highlightColor);
                    
                    __cl_gen_to_be_invoked.PrintOverlay( start, end, caret, highlight, caretColor, highlightColor );
                    
                    
                    
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
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_ApplyOffset(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> verts = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    int start = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Vector2 __cl_gen_ret = __cl_gen_to_be_invoked.ApplyOffset( verts, start );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyShadow(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> verts = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector2> uvs = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Color> cols = (System.Collections.Generic.List<UnityEngine.Color>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Color>));
                    int start = LuaAPI.xlua_tointeger(L, 5);
                    int end = LuaAPI.xlua_tointeger(L, 6);
                    float x = (float)LuaAPI.lua_tonumber(L, 7);
                    float y = (float)LuaAPI.lua_tonumber(L, 8);
                    
                    __cl_gen_to_be_invoked.ApplyShadow( verts, uvs, cols, start, end, x, y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateOffsetToFit(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.CalculateOffsetToFit( text );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCurrentProgress(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetCurrentProgress(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCurrentPercent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetCurrentPercent(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCurrentSelection(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetCurrentSelection(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Wrap(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    string final;
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Wrap( text, out final );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.lua_pushstring(L, final);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    string final;
                    int height = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Wrap( text, out final, height );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.lua_pushstring(L, final);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UILabel.Wrap!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateNGUIText(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.UpdateNGUIText(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalFontSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.finalFontSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isAnchoredHorizontally(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isAnchoredHorizontally);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isAnchoredVertically(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isAnchoredVertically);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mainTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bitmapFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.bitmapFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trueTypeFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.trueTypeFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambigiousFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.ambigiousFont);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_text(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.text);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultFontSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.defaultFontSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.fontSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.fontStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alignment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.alignment);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.gradientBottom);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spacingX(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.spacingX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spacingY(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.spacingY);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useFloatSpacing(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useFloatSpacing);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_floatSpacingX(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.floatSpacingX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_floatSpacingY(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.floatSpacingY);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_effectiveSpacingY(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.effectiveSpacingY);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_effectiveSpacingX(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.effectiveSpacingX);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overflowEllipsis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.overflowEllipsis);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overflowWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.overflowWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportEncoding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.supportEncoding);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_symbolStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.symbolStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overflowMethod(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.overflowMethod);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_multiLine(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.multiLine);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.worldCorners);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.drawingDimensions);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxLineCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maxLineCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_effectStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.effectStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_effectColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.effectColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_effectDistance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.effectDistance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_quadsPerCharacter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.quadsPerCharacter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_processedText(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.processedText);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_printedSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.printedSize);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.localSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_modifier(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.modifier);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_printedText(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.printedText);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keepCrispWhenShrunk(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.keepCrispWhenShrunk);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customModifier(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.customModifier);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_material(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mainTexture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bitmapFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bitmapFont = (UIFont)translator.GetObject(L, 2, typeof(UIFont));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trueTypeFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.trueTypeFont = (UnityEngine.Font)translator.GetObject(L, 2, typeof(UnityEngine.Font));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambigiousFont(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ambigiousFont = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_text(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.text = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fontSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fontSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fontStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                UnityEngine.FontStyle __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.fontStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alignment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                NGUIText.Alignment __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.alignment = __cl_gen_value;
            
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
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
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.gradientBottom = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spacingX(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.spacingX = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spacingY(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.spacingY = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useFloatSpacing(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useFloatSpacing = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_floatSpacingX(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.floatSpacingX = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_floatSpacingY(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.floatSpacingY = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overflowEllipsis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.overflowEllipsis = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overflowWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.overflowWidth = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_supportEncoding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.supportEncoding = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_symbolStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                NGUIText.SymbolStyle __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.symbolStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overflowMethod(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                UILabel.Overflow __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.overflowMethod = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_multiLine(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.multiLine = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxLineCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maxLineCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_effectStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                UILabel.Effect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.effectStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_effectColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.effectColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_effectDistance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.effectDistance = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_modifier(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                UILabel.Modifier __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.modifier = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keepCrispWhenShrunk(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                UILabel.Crispness __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.keepCrispWhenShrunk = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customModifier(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UILabel __cl_gen_to_be_invoked = (UILabel)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.customModifier = translator.GetDelegate<UILabel.ModifierFunc>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
