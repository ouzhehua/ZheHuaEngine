using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
public class GizmosHelperEditor : Editor
{
    [MenuItem("Tools/QuickCheckHelper/Gizmos Helper &g", false, 100)]
    public static void AddGizmosHelper()
    {
        GameObject go = Selection.activeGameObject;

        if (go != null)
        {
            GizmosHelper temp = go.GetComponent<GizmosHelper>();
            if (temp == null)
            {
                go.AddComponent<GizmosHelper>();
            }
            else
            {
                Debug.Log("help you delete");
                DestroyImmediate(temp);
            }
        }
        else GameFramework.Log.Info("You must select a game object first.");
    }
}
#endif
public class GizmosHelper : MonoBehaviour
{
    public bool gizmosEnable = true;

    public enum GizmosType
    {
        Cube,
        Circle
    }

    public GizmosType gizmosType = GizmosType.Circle;
    public Color color = Color.blue;
    public float length = 0.25f;
    void Awake()
    {
        if (Application.isPlaying)
        {
            Debug.LogError("mmp！谁让你把我带到游戏里的，我只是个监测工具，快删了 " + gameObject.name);
        }
    }

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        if (gizmosEnable)
        {
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.color = color;
            
            switch(gizmosType)
            {
                case GizmosType.Circle:
                    Gizmos.DrawSphere(Vector3.zero, length);
                    break;
                case GizmosType.Cube:
                    //Gizmos.DrawWireCube(new Vector3(0, 0, 0), new Vector3(1f, 1f, 1f));
                    Gizmos.DrawCube(Vector3.zero, new Vector3(length, length, length));
                    break;
                default:
                    Debug.LogError("you should case " + gizmosType);
                    break;
            }
        }
    }
#endif
}