#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(LuaBehaviour), LuaBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaScriptUtil), LuaScriptUtilWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIPanel), UIPanelWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIWidget), UIWidgetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UISprite), UISpriteWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UITexture), UITextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIButton), UIButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UILabel), UILabelWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIInput), UIInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UIEventTrigger), UIEventTriggerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NGUITools), NGUIToolsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UITweener), UITweenerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenAlpha), TweenAlphaWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenColor), TweenColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenHeight), TweenHeightWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenWidth), TweenWidthWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenLetters), TweenLettersWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenPosition), TweenPositionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenRotation), TweenRotationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenScale), TweenScaleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(TweenTransform), TweenTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.AutoPlay), DGTweeningAutoPlayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.AxisConstraint), DGTweeningAxisConstraintWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.Ease), DGTweeningEaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.LogBehaviour), DGTweeningLogBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.LoopType), DGTweeningLoopTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.PathMode), DGTweeningPathModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.PathType), DGTweeningPathTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.RotateMode), DGTweeningRotateModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.ScrambleMode), DGTweeningScrambleModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.TweenType), DGTweeningTweenTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.UpdateType), DGTweeningUpdateTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.DOTween), DGTweeningDOTweenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.DOVirtual), DGTweeningDOVirtualWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.EaseFactory), DGTweeningEaseFactoryWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.Tweener), DGTweeningTweenerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.Tween), DGTweeningTweenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.Sequence), DGTweeningSequenceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.TweenParams), DGTweeningTweenParamsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.Core.ABSSequentiable), DGTweeningCoreABSSequentiableWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>), DGTweeningCoreTweenerCore_3_UnityEngineVector3UnityEngineVector3DGTweeningPluginsOptionsVectorOptions_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.TweenExtensions), DGTweeningTweenExtensionsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.TweenSettingsExtensions), DGTweeningTweenSettingsExtensionsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.ShortcutExtensions), DGTweeningShortcutExtensionsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.ShortcutExtensions43), DGTweeningShortcutExtensions43Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.ShortcutExtensions46), DGTweeningShortcutExtensions46Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(DG.Tweening.ShortcutExtensions50), DGTweeningShortcutExtensions50Wrap.__Register);
				
				
				
				translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
