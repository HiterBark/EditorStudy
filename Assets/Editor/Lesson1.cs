

using UnityEditor;
using UnityEngine;

public class Lesson1
{
    [MenuItem("GameObject/Lesson1/TestFun _%F4")]
    public static void GameObjectTest()
    {
        Debug.Log("TestFun");
    }
    [MenuItem("Assets/Lesson1/AssetsTest")]
    public static void AssetsTest()
    {
        Debug.Log("AssetsTest");
    }
    [MenuItem("CONTEXT/Light/自定义功能")]
    public static void CONTEXTTest()
    {
        Debug.Log("CONTEXTTest");
    }
}
 
