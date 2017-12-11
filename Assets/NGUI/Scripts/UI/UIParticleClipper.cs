using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(UIParticleClipper))]
public class UIParticleClipperEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector ();
        UIParticleClipper self = (UIParticleClipper)target;

        if (GUILayout.Button("Cache Particles In Array"))
        {
            self.cacheParticles = self.GetComponentsInChildren<ParticleSystem>(true);
            self.useCacheParticlesOnBuild = true;
        }

        if (GUILayout.Button("ReBuild"))
        {
            self.BuildSyncDataAndRunCoroutine(self.useCacheParticlesOnBuild, self.needReplaceShaderOnBuild);
        }
    }
}
#endif

//add by zhehua
[RequireComponent(typeof(UIPanel))]
public class UIParticleClipper : MonoBehaviour
{
    [System.Serializable]
    public class ReplaceShaderData
    {
        public string OriginalName;
        public string ReplaceName;
        public ReplaceShaderData(string OriginalName, string ReplaceName)
        {
            this.OriginalName = OriginalName;
            this.ReplaceName = ReplaceName;
        }
    }

    public ParticleSystem[] cacheParticles;
    /// <summary>
    /// 使用序列化缓存的粒子来初始化
    /// </summary>
    public bool useCacheParticlesOnBuild;
    /// <summary>
    /// 是否需要动态更换材质
    /// </summary>
    public bool needReplaceShaderOnBuild = true;
    public List<ReplaceShaderData> ReplaceShaderMap = new List<ReplaceShaderData> {
        new ReplaceShaderData("Particles/Additive", "Hidden/Unlit/Particles/Additive Clip"),
        new ReplaceShaderData("Particles/Alpha Blended", "Hidden/Unlit/Particles/Alpha Blended Clip")
    };

    /// <summary>
    /// 刷新边界帧率,默认是15帧刷一次
    /// 0代表不刷新,采用初始化时的值。1代表每帧刷新,以此类推。设定最小值是0,最大值是30。
    /// </summary>
    [SerializeField]
    [SetProperty("UpdateClipRangeFrameRate")]
    private int m_UpdateClipRangeFrameRate = 15;
    public int UpdateClipRangeFrameRate
    {
        set
        {
            if(value <= 0)
            {
                m_UpdateClipRangeFrameRate = 0;
                StopSyncClipRangeCoroutine();
            }
            else if (value > 30)
            {
                m_UpdateClipRangeFrameRate = 30;
                StartSyncClipRangeCoroutine();
            }
            else
            {
                m_UpdateClipRangeFrameRate = value;
                StartSyncClipRangeCoroutine();
            }
        }
        get { return m_UpdateClipRangeFrameRate; }
    }

    UIPanel m_targetPanel;
    void Start()
    {
        m_targetPanel = GetComponent<UIPanel>();

        if (m_targetPanel == null)
            throw new ArgumentNullException("Cann't find the right UIPanel");
        if (m_targetPanel.clipping != UIDrawCall.Clipping.SoftClip)
            throw new InvalidOperationException("Don't need to clip");

        BuildSyncDataAndRunCoroutine(useCacheParticlesOnBuild, needReplaceShaderOnBuild);
    }

    Coroutine _syncClipRangeCoroutine;
    int _frameCountDown;
    void StartSyncClipRangeCoroutine()
    {
        SyncClipRange();
        if (_syncClipRangeCoroutine == null && m_UpdateClipRangeFrameRate > 0)
        {
            _frameCountDown = m_UpdateClipRangeFrameRate;
            _syncClipRangeCoroutine = StartCoroutine(SyncClipCoroutine());
        }
    }
    void StopSyncClipRangeCoroutine()
    {
        if (_syncClipRangeCoroutine != null)
        {
            StopCoroutine(_syncClipRangeCoroutine);
            _syncClipRangeCoroutine = null;
        }
    }

    /// <summary>
    /// 同步边界数据协程
    /// </summary>
    /// <returns></returns>
    IEnumerator SyncClipCoroutine()
    {
        WaitForEndOfFrame yieldInstance = new WaitForEndOfFrame();
        while(true)
        {
            _frameCountDown--;
            if (_frameCountDown < 0)
            {
                _frameCountDown = m_UpdateClipRangeFrameRate;
                SyncClipRange();
            }
            yield return yieldInstance;
        }
    }

    /// <summary>
    /// 计算当前边界数据
    /// </summary>
    void CalcClipRange()
    {
        Vector4 cr = m_targetPanel.drawCallClipRange;

        Vector2 soft = m_targetPanel.clipSoftness;
        if (soft.x > 0f) _clipArgs.x = cr.z / soft.x;
        if (soft.y > 0f) _clipArgs.y = cr.w / soft.y;

        //经过测试粒子系统产生的Mesh是不受UIPanel缩放比影响的,所以要将其缩放比记录下来
        float scale = m_targetPanel.transform.lossyScale.x;
        Vector3 position = m_targetPanel.transform.position;

        _clipRange.x = -cr.x / cr.z - position.x / scale / cr.z;
        _clipRange.y = -cr.y / cr.w - position.y / scale / cr.w;
        _clipRange.z = 1f / cr.z / scale;
        _clipRange.w = 1f / cr.w / scale;
    }

    Vector4 _clipRange = new Vector4();
    Vector2 _clipArgs = new Vector2();
    /// <summary>
    /// 同步边界数据到缓存材质球上的Shader里
    /// </summary>
    void SyncClipRange()
    {
        CalcClipRange();

        var enumerator = _cacheSyncData.GetEnumerator();
        List<Material> removeKeys = null;
        while (enumerator.MoveNext())
        {
            int gameObjectsCount = enumerator.Current.Value.gameObjects.Count;
            if (gameObjectsCount == 0)
            {
                if (removeKeys == null)
                {
                    removeKeys = new List<Material>();
                }
                removeKeys.Add(enumerator.Current.Key);
                continue;
            }

            bool syncTestPass = false;
            for (int i = gameObjectsCount - 1; i >= 0; i--)
            {
                if (enumerator.Current.Value.gameObjects[i].gameObject == null)
                {
                    enumerator.Current.Value.gameObjects.RemoveAt(i);
                }
                else if (enumerator.Current.Value.gameObjects[i].gameObject.activeInHierarchy)
                {
                    syncTestPass = true;
                }
            }

            if (syncTestPass)
            {
                enumerator.Current.Value.material.SetVector("_ClipRange0", _clipRange);
                enumerator.Current.Value.material.SetVector("_ClipArgs0", _clipArgs);
            }
        }

        if (removeKeys != null && removeKeys.Count > 0)
        {
            for (int i = 0; i < removeKeys.Count; i++)
            {
                _cacheSyncData.Remove(removeKeys[i]);
            }
        }
    }

    struct SyncData
    {
        public Material material;
        public List<GameObject> gameObjects;
    }

    Dictionary<Material, SyncData> _cacheSyncData = new Dictionary<Material, SyncData>();
    /// <summary>
    /// 创建刷新数据并运行协程。替换Shader和缓存材质。Start时会主动调用一次, Panel下子节点有变化时手动调用
    /// </summary>
    /// <param name="replaceShader">是否顺便替换shader</param>
    public void BuildSyncDataAndRunCoroutine(bool useCacheParticles, bool needReplaceShader)
    {
        //重置缓存同步数据
        var enumerator = _cacheSyncData.GetEnumerator();
        while (enumerator.MoveNext())
        {
            for (int i = 0; i < enumerator.Current.Value.gameObjects.Count; i++)
            {
                enumerator.Current.Value.gameObjects[i].GetComponent<Renderer>().sharedMaterial = enumerator.Current.Key;
            }
        }
        _cacheSyncData.Clear();

        //不使用已有缓存,重新查找节点并缓存
        if (!useCacheParticles)
        {
            cacheParticles = this.GetComponentsInChildren<ParticleSystem>(true);
        }

        //取得粒子材质球种类
        for (int i = 0; i < cacheParticles.Length; i++)
        {
            PushParticleToSyncData(cacheParticles[i], needReplaceShader);
        }

        StartSyncClipRangeCoroutine();
    }

    /// <summary>
    /// 往同步数据里添加新粒子
    /// </summary>
    /// <param name="particle"></param>
    /// <param name="needReplaceShader"></param>
    public void PushParticleToSyncData(ParticleSystem particle, bool needReplaceShader)
    {
        if (particle == null)
        {
            return;
        }

        Renderer render = particle.gameObject.GetComponent<Renderer>();
        Material material = render.sharedMaterial;

        if (_cacheSyncData.ContainsKey(material))
        {
            _cacheSyncData[material].gameObjects.Add(particle.gameObject);
            render.sharedMaterial = _cacheSyncData[material].material;
        }
        else
        {
            SyncData data;
            data.gameObjects = new List<GameObject>();
            data.gameObjects.Add(particle.gameObject);
            data.material = CreateDynamicMaterial(material, _cacheSyncData.Count, needReplaceShader);
            render.sharedMaterial = data.material;
            _cacheSyncData.Add(material, data);
        }
    }

    /// <summary>
    /// 替换材质球上的shader,依据 ReplaceShaderMap 里的数据
    /// </summary>
    /// <param name="material">目标材质球</param>
    void ReplaceShader(Material material)
    {
        for (int i = 0; i < ReplaceShaderMap.Count; i++)
        {
            if (ReplaceShaderMap[i].OriginalName == material.shader.name)
            {
                material.shader = Shader.Find(ReplaceShaderMap[i].ReplaceName);
                return;
            }
        }
    }
    /// <summary>
    /// 创建临时共享材质球
    /// </summary>
    /// <param name="material"></param>
    /// <param name="queue"></param>
    /// <param name="needReplaceShader"></param>
    /// <returns></returns>
    Material CreateDynamicMaterial(Material material, int queue, bool needReplaceShader)
    {
        Material temp = new Material(material);
        temp.name = "[NGUI Particle] " + material.name;
        temp.hideFlags = (HideFlags.DontSave | HideFlags.NotEditable);
        temp.CopyPropertiesFromMaterial(material);
        //Hierarchy里的节点顺序可以影响GetComponentsInChildren数组的顺序，也就影响了RenderQueue
        temp.renderQueue = 3000 + queue;

#if !UNITY_FLASH
        string[] keywords = material.shaderKeywords;
        for (int i = 0; i < keywords.Length; ++i)
        {
            temp.EnableKeyword(keywords[i]);
        }
#endif

        //需要替换shader
        if (needReplaceShader)
        {
            ReplaceShader(temp);
        }

        return temp;
    }
}