using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;


#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(RenderShadow))]
public class RenderShadowEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        RenderShadow self = (RenderShadow)target;
        if (Application.isPlaying)
        {
            EditorGUILayout.BeginHorizontal();
            bool oldValue = self.hasInit;
            bool newValue = EditorGUILayout.Toggle(self.hasInit, GUILayout.Width(15));
            EditorGUILayout.LabelField("Do Init Function", GUILayout.Width(100));
            EditorGUILayout.EndHorizontal();
            if (oldValue == false && newValue == true)
            {
                self.Init();
            }
        }
    }
}

#endif

public class RenderShadow : MonoBehaviour
{
    //手拖调试用
    [SerializeField]
    private Camera targetCamera;
    [SerializeField]
    private List<LayerEnum> targetLayer;
    [SerializeField]
    private List<Transform> targetList;
    [SerializeField]
    private QualityMode currentMode;

    private bool _hasInit = false;
    public bool hasInit
    {
        get { return _hasInit; }
    }

    private Camera _shadowCamera;
    private RenderTexture _shadowTexture;
    private Projector _projector;

    private Matrix4x4 matVP;
    private Matrix4x4 m_projMatrix;

    public enum QualityMode
    {
        Low,
        Medium,
        High
    }

    private static RenderShadow _instance;
    public static RenderShadow instance
    {
        get
        { return _instance; }
    }

    private int renderTextureSize
    {
        get
        {
            switch (currentMode)
            {
                case QualityMode.Low:
                    return 512;
                case QualityMode.Medium:
                    return 1024;
                case QualityMode.High:
                    return 2048;
                default:
                    return 1024;
            }
        }
    }

    public void Init()
    {
        if (_hasInit)
        {
            return;
        }

        _shadowCamera = gameObject.GetComponent<Camera>();
        //_shadowCamera.hideFlags = HideFlags.HideAndDontSave;
        _shadowCamera.enabled = false;
        _shadowCamera.nearClipPlane = -15;
        _shadowCamera.farClipPlane = 15;
        for (int i = 0; i < targetLayer.Count; i++)
        {
            _shadowCamera.cullingMask |= (1 << (int)targetLayer[i]);
        }

        int textureSize = renderTextureSize;
        _shadowTexture = new RenderTexture(textureSize, textureSize, 0, RenderTextureFormat.ARGB32);
        _shadowTexture.name = "RenderShadowTexture";
        _shadowTexture.isPowerOfTwo = true;
        _shadowTexture.hideFlags = HideFlags.DontSave;
        _shadowCamera.targetTexture = _shadowTexture;

        _projector = gameObject.GetComponent<Projector>();
        _projector.nearClipPlane = targetCamera.nearClipPlane;
        _projector.farClipPlane = targetCamera.farClipPlane;
        _projector.fieldOfView = targetCamera.fieldOfView;
        //设置 ignoreLayers
        _projector.ignoreLayers = ~(1 << (int)LayerEnum.RenderShadowReciver);
        matVP = GL.GetGPUProjectionMatrix(_shadowCamera.projectionMatrix, true) * _shadowCamera.worldToCameraMatrix;
        _projector.material.SetMatrix("ShadowMatrix", matVP);
        //_shadowCamera.SetReplacementShader (Shader.Find ("depthShader"), "");

        _instance = this;
        _hasInit = true;
    }

    void Update()
    {
        if (!_hasInit)
        {
            return;
        }

        UpdataCameraPosition();
        CreateCameraProjecterMatrix();
        _projector.material.SetMatrix("ShadowMatrix", matVP);
        _shadowCamera.Render();
        _projector.material.SetTexture("_ShadowTex", _shadowTexture);
    }

    void OnDestroy()
    {
        if (_shadowTexture != null)
        {
            DestroyImmediate(_shadowTexture);
        }
        targetCamera = null;
        targetList.Clear();

        _instance = null;
    }

    /// <summary>
    /// 传入必须数据,初始化
    /// </summary>
    /// <param name="targetCamera">场景主相机</param>
    /// <param name="targetList">需要产生阴影的显示对象</param>
    /// <param name="lightEulerAngles">场景内平行光的欧拉角</param>
    public void SetData(Camera targetCamera, List<Transform> targetList, Vector3 lightEulerAngles, QualityMode qualityMode = QualityMode.High)
    {
        this.targetCamera = targetCamera;
        if (targetList == null)
        {
            targetList = new List<Transform>();
        }
        this.targetList = targetList;
        transform.eulerAngles = lightEulerAngles;
        currentMode = qualityMode;
        Init();
    }

    public void AddTargetToList(Transform tf)
    {
        this.targetList.Add(tf);
    }

    public void RemoveTargetFromList(Transform tf)
    {
        this.targetList.Remove(tf);
    }

    void UpdataCameraPosition()
    {
        //暴力移除 能不开就不开
        //targetList.RemoveAll (item => item == null);

        if (targetList.Count == 0)
        {
            return;
        }

        Vector3 newPosition = Vector3.zero;
        for (int i = 0; i < targetList.Count; i++)
        {
            if (targetList[i] == null)
            {
                Debug.LogError("Null Target Remove");
                targetList.RemoveAt(i);
                i--;
            }
            else
            {
                newPosition += targetList[i].position;
            }
        }

        transform.position = (newPosition / targetList.Count);
    }

    void CreateCameraProjecterMatrix()
    {
        if (targetList.Count > 1)
        {
            Vector3 v3MaxPosition = -Vector3.one * 500000.0f;
            Vector3 v3MinPosition = Vector3.one * 500000.0f;
            for (int vertId = 0; vertId < targetList.Count; ++vertId)
            {
                // Light view space
                Vector3 v3Position = _shadowCamera.worldToCameraMatrix.MultiplyPoint3x4(targetList[vertId].position);
                if (v3Position.x > v3MaxPosition.x)
                {
                    v3MaxPosition.x = v3Position.x;
                }
                if (v3Position.y > v3MaxPosition.y)
                {
                    v3MaxPosition.y = v3Position.y;
                }
                if (v3Position.z > v3MaxPosition.z)
                {
                    v3MaxPosition.z = v3Position.z;
                }
                if (v3Position.x < v3MinPosition.x)
                {
                    v3MinPosition.x = v3Position.x;
                }
                if (v3Position.y < v3MinPosition.y)
                {
                    v3MinPosition.y = v3Position.y;
                }
                if (v3Position.z < v3MinPosition.z)
                {
                    v3MinPosition.z = v3Position.z;
                }
                Vector3 off = v3MaxPosition - v3MinPosition;
                Vector3 sizeOff = off;
                float dis = sizeOff.magnitude;
                _shadowCamera.orthographicSize = dis / 1f;
            }
        }
        else
        {
            _shadowCamera.orthographicSize = 3f;
        }

        matVP = GL.GetGPUProjectionMatrix(_shadowCamera.projectionMatrix, true) * _shadowCamera.worldToCameraMatrix;
    }
}