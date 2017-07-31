using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public sealed partial class GameEntry : MonoBehaviour
{
    private static GameEntry s_Instance = null;
    [SerializeField]
    private BaseComponent m_Base = null;
    [SerializeField]
    private DataNodeComponent m_DataNode = null;
    [SerializeField]
    private DataTableComponent m_DataTable = null;
    [SerializeField]
    private DownloadComponent m_Download = null;
    [SerializeField]
    private EntityComponent m_Entity = null;
    [SerializeField]
    private EventComponent m_Event = null;
    [SerializeField]
    private FsmComponent m_Fsm = null;
    [SerializeField]
    private LocalizationComponent m_Localization = null;
    [SerializeField]
    private NetworkComponent m_Network = null;
    [SerializeField]
    private ObjectPoolComponent m_ObjectPool = null;
    [SerializeField]
    private ProcedureComponent m_Procedure = null;
    [SerializeField]
    private ResourceComponent m_Resource = null;
    [SerializeField]
    private SceneComponent m_Scene = null;
    [SerializeField]
    private SettingComponent m_Setting = null;
    [SerializeField]
    private SoundComponent m_Sound = null;
    [SerializeField]
    private UIComponent m_UI = null;
    [SerializeField]
    private WebRequestComponent m_WebRequest = null;

    [SerializeField]
    private XLuaComponent m_XLua = null;

    public static bool IsAvailable
    {
        get
        {
            return s_Instance;
        }
    }

    public static BaseComponent GameBase
    {
        get
        {
            return s_Instance.m_Base;
        }
    }
    public static DataNodeComponent DataNode
    {
        get
        {
            return s_Instance.m_DataNode;
        }
    }
    public static DataTableComponent DataTable
    {
        get
        {
            return s_Instance.m_DataTable;
        }
    }
    public static DownloadComponent Download
    {
        get
        {
            return s_Instance.m_Download;
        }
    }
    public static EntityComponent Entity
    {
        get
        {
            return s_Instance.m_Entity;
        }
    }
    public static EventComponent Event
    {
        get
        {
            return s_Instance.m_Event;
        }
    }
    public static FsmComponent Fsm
    {
        get
        {
            return s_Instance.m_Fsm;
        }
    }
    public static LocalizationComponent Localization
    {
        get
        {
            return s_Instance.m_Localization;
        }
    }
    public static NetworkComponent Network
    {
        get
        {
            return s_Instance.m_Network;
        }
    }
    public static ObjectPoolComponent ObjectPool
    {
        get
        {
            return s_Instance.m_ObjectPool;
        }
    }
    public static ProcedureComponent Procedure
    {
        get
        {
            return s_Instance.m_Procedure;
        }
    }
    public static ResourceComponent Resource
    {
        get
        {
            return s_Instance.m_Resource;
        }
    }
    public static SceneComponent Scene
    {
        get
        {
            return s_Instance.m_Scene;
        }
    }
    public static SettingComponent Setting
    {
        get
        {
            return s_Instance.m_Setting;
        }
    }
    public static SoundComponent Sound
    {
        get
        {
            return s_Instance.m_Sound;
        }
    }
    public static UIComponent UI
    {
        get
        {
            return s_Instance.m_UI;
        }
    }
    public static WebRequestComponent WebRequest
    {
        get
        {
            return s_Instance.m_WebRequest;
        }
    }
    public static XLuaComponent XLua
    {
        get
        {
            return s_Instance.m_XLua;
        }
    }

    public static void Restart()
    {
        UnityGameFramework.Runtime.GameEntry.Shutdown(ShutdownType.Restart);
    }

    public static void ShutDown()
    {
        UnityGameFramework.Runtime.GameEntry.Shutdown(ShutdownType.Quit);
    }
}