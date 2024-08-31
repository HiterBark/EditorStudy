
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Lesson22))]
public class Lesson22Editor : Editor
{
    private SerializedProperty atk;
    private SerializedProperty def;
    private SerializedProperty obj;

    private bool foldOut;
    private void OnEnable()
    {
        atk = serializedObject.FindProperty("atk");
        def = serializedObject.FindProperty("def");
        obj = serializedObject.FindProperty("obj");
    }
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        serializedObject.Update();

        foldOut = EditorGUILayout.BeginFoldoutHeaderGroup(foldOut, "折叠");
        if (foldOut)
        {
            GUILayout.Button("8888");
            EditorGUILayout.IntSlider(atk, 0, 100,"攻击力");
        }
        EditorGUILayout.EndFoldoutHeaderGroup();
        serializedObject.ApplyModifiedProperties();
    }
}
