using System.Collections.Generic;
using System;
using UnityEngine;
using XLua;

//配置的详细介绍请看Doc下《XLua的配置.doc》
public static class XLuaGenConfig
{
    //lua中要使用到C#库的配置，比如C#标准库，或者Unity API，第三方库等。
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>() {
		typeof(System.Object),
		typeof(UnityEngine.Object),
		typeof(Vector2),
		typeof(Vector3),
		typeof(Vector4),
		typeof(Quaternion),
		typeof(Color),
		typeof(Ray),
		typeof(Bounds),
		typeof(Ray2D),
		typeof(Time),
		typeof(GameObject),
		typeof(Component),
		typeof(Behaviour),
		typeof(Transform),
		typeof(Resources),
		typeof(TextAsset),
		typeof(Keyframe),
		typeof(AnimationCurve),
		typeof(AnimationClip),
		typeof(MonoBehaviour),
		typeof(ParticleSystem),
		typeof(SkinnedMeshRenderer),
		typeof(Renderer),
		typeof(WWW),
		typeof(System.Collections.Generic.List<int>),
		typeof(Action<string>),
		typeof(UnityEngine.Debug),
        typeof(WaitForSeconds),

        //EventDelegate
        typeof(LuaScriptUtil),
        //NGUI
        typeof(UIPanel),
        typeof(UIWidget),
        typeof(UISprite),
        typeof(UITexture),
        typeof(UIButton),
        typeof(UILabel),
        typeof(UIInput),
        typeof(UIEventTrigger),
        typeof(NGUITools),

        typeof(UITweener),
        typeof(TweenAlpha),
        typeof(TweenColor),
        typeof(TweenHeight),
        typeof(TweenWidth),
        typeof(TweenLetters),
        typeof(TweenPosition),
        typeof(TweenRotation),
        typeof(TweenScale),
        typeof(TweenTransform),

        //Dotween
        typeof(DG.Tweening.AutoPlay),
        typeof(DG.Tweening.AxisConstraint),
        typeof(DG.Tweening.Ease),
        typeof(DG.Tweening.LogBehaviour),
        typeof(DG.Tweening.LoopType),
        typeof(DG.Tweening.PathMode),
        typeof(DG.Tweening.PathType),
        typeof(DG.Tweening.RotateMode),
        typeof(DG.Tweening.ScrambleMode),
        typeof(DG.Tweening.TweenType),
        typeof(DG.Tweening.UpdateType),

        typeof(DG.Tweening.DOTween),
        typeof(DG.Tweening.DOVirtual),
        typeof(DG.Tweening.EaseFactory),
        typeof(DG.Tweening.Tweener),
        typeof(DG.Tweening.Tween),
        typeof(DG.Tweening.Sequence),
        typeof(DG.Tweening.TweenParams),
        typeof(DG.Tweening.Core.ABSSequentiable),

        typeof(DG.Tweening.Core.TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions>),

        typeof(DG.Tweening.TweenCallback),
        typeof(DG.Tweening.TweenExtensions),
        typeof(DG.Tweening.TweenSettingsExtensions),
        typeof(DG.Tweening.ShortcutExtensions),
        typeof(DG.Tweening.ShortcutExtensions43),
        typeof(DG.Tweening.ShortcutExtensions46),
        typeof(DG.Tweening.ShortcutExtensions50),
       
        //dotween pro 的功能
        //typeof(DG.Tweening.DOTweenPath),
        //typeof(DG.Tweening.DOTweenVisualManager),
	};

    //C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface
    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>() {
		typeof(Action),
		typeof(Func<double, double, double>),
		typeof(Action<string>),
		typeof(Action<double>),
        typeof(Action<LuaTable>),
        typeof(Action<LuaTable, object>),
		typeof(UnityEngine.Events.UnityAction),
		typeof(System.Collections.IEnumerator)
	};

    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
		new List<string>(){"UnityEngine.WWW", "movie"},
		new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
		new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
		new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
		new List<string>(){"UnityEngine.Light", "areaSize"},
		new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
		#if !UNITY_WEBPLAYER
		new List<string>(){"UnityEngine.Application", "ExternalEval"},
		#endif
		new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
		new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
		new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
		new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
		new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
		new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
		new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
		new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
		new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},
	};
}