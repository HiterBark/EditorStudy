using UnityEditor;

public class BuildManager
{
    [MenuItem("BuildManager/BuildApk")]
    public static void BuildAkp()
    {
        BuildPlayerOptions options = new BuildPlayerOptions();
        string[] scenePaths = new string[EditorBuildSettings.scenes.Length];

        for (int i = 0; i < EditorBuildSettings.scenes.Length; i++)
        {
            scenePaths[i] = EditorBuildSettings.scenes[i].path;
        }
        options.scenes = scenePaths;

        options.target = BuildTarget.Android;
        options.options = BuildOptions.None;
        options.locationPathName = @"C:\Users\TestBuild.apk";

        BuildPipeline.BuildPlayer(options);
    }
}
