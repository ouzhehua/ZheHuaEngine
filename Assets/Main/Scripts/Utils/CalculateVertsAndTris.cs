/// <summary>
/// Calculate verts and tris editor.
/// add by zhehua
/// 计算模型顶点和面数，挂在对应的模型上，然后点一下按钮就看见了
/// </summary>

using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(CalculateVertsAndTris))]
public class CalculateVertsAndTrisEditor : Editor {
	public override void OnInspectorGUI()
	{
		//DrawDefaultInspector ();
		CalculateVertsAndTris self = (CalculateVertsAndTris)target;

		GUILayout.Label ("Verts Count : " + self.vertsValue);
		GUILayout.Label ("Tris Count : " + self.trisValue);

		if (GUILayout.Button ("Calculate This GameObject")) {
			self.Calculate ();
		}
	}

	[MenuItem("Tools/QuickCheckHelper/Calculate Verts And Tris &t", false, 100)]
	public static void AddCalculate ()
	{
		GameObject go = Selection.activeGameObject;

		if (go != null)
		{
			CalculateVertsAndTris temp = go.GetComponent<CalculateVertsAndTris> ();
			if (temp == null) {
				go.AddComponent<CalculateVertsAndTris> ();
			}
            else {
                Debug.Log("help you delete");
                DestroyImmediate(temp);
            }
		}
		else GameFramework.Log.Info("You must select a game object first.");
	}
}

#endif

public class CalculateVertsAndTris : MonoBehaviour
{
	void Awake()
	{
        if(Application.isPlaying)
        {
            Debug.LogError("操你妈！谁让你把我带到游戏里的，我只是个监测工具，快删了 " + gameObject.name);
        }
		Calculate ();
	}

	public int vertsValue;
	public int trisValue;
	public void Calculate()
	{
		trisValue = 0;
		vertsValue = 0;

		Component[] filters;
		filters = gameObject.GetComponentsInChildren<MeshFilter>();
		if (filters.Length == 0) {
            GameFramework.Log.Error("filters'Length is zero");

			return;
		}

		foreach (MeshFilter f in filters)
		{
			trisValue += (f.sharedMesh.triangles.Length / 3);
			vertsValue += f.sharedMesh.vertexCount;
		}
	}
}