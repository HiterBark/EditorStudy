using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class addresbleTools
{
    [MenuItem("Tools/Jenking����")]
    public static void TestJenkings()
    {
        string[] comm = Environment.GetCommandLineArgs();
        foreach (var item in comm)
        {
            Debug.Log($"Jenkingָ�{item}");
        }
    }
}
