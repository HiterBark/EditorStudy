using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

public class Lesson8 : EditorWindow
{
    [MenuItem("Tools/Lesson8")]
    private static void OpenLesson8()
    {
        Lesson8 lesson8 = EditorWindow.GetWindow<Lesson8>();
        lesson8.Show();
    }
    StringBuilder name = new StringBuilder("没有选着");
    StringBuilder gamename = new StringBuilder("没有选着");
    StringBuilder allgamename = new StringBuilder("没有选着");
    private void OnGUI()
    {
        if (GUILayout.Button("获取名字"))
        {
            if (Selection.activeObject != null)
            {
                name.Clear();
                name.Append(Selection.activeObject.name);
            }
        }

        EditorGUILayout.LabelField(name.ToString());

        if (GUILayout.Button("获取gameobject名字"))
        {
            if (Selection.activeGameObject != null)
            {
                gamename.Clear();
                gamename.Append(Selection.activeObject.name);
            }
        }

        EditorGUILayout.LabelField(gamename.ToString());

        if (GUILayout.Button("获取allgameobject名字"))
        {
            if (Selection.objects.Length > 0)
            {
                allgamename.Clear();
                for (int i = 0; i < Selection.objects.Length; i++)
                {

                    allgamename.Append(Selection.objects[i].name + "||");
                }
            }
        }

        EditorGUILayout.LabelField(allgamename.ToString());

        obj = EditorGUILayout.ObjectField("选着对象", obj, typeof(GameObject), false) as GameObject;

        if (GUILayout.Button("8888"))
        {
            if (Selection.Contains(obj))
            {
                Debug.Log("相同的");
            }
            else
            {
                Debug.Log("不同的");
            }
        }
        if (GUILayout.Button("刷选"))
        {
            Object[] objects = Selection.GetFiltered<Object>(SelectionMode.DeepAssets | SelectionMode.Assets);
            for (int i = 0; i < objects.Length; i++)
            {
                Debug.Log(objects[i].name);
            }
        }
    }
    GameObject obj;
}
