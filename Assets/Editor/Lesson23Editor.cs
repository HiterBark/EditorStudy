

using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Lesson23))]
public class Lesson23Editor : Editor
{
    private SerializedProperty hp;
    private SerializedProperty name;
    private SerializedProperty img;

    private void OnEnable()
    {
        hp = serializedObject.FindProperty("hp");
        name = serializedObject.FindProperty("name");
        img = serializedObject.FindProperty("img");
    }
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        serializedObject.Update();

        hp.floatValue = EditorGUILayout.FloatField("Ѫ��", hp.floatValue);
        name.stringValue = EditorGUILayout.TextField("����", name.stringValue);

       EditorGUILayout.ObjectField(img,new GUIContent("ͷ��"));

        serializedObject.ApplyModifiedProperties();
    }
}
