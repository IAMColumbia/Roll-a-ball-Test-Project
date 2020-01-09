using UnityEditor;
class StandaloneWindowsBuild
{
    static void build()
    {
        string[] scenes = {"Assets/Scenes/SampleScene.unity"};
        string pathToDeploy = "builds/WindowsStandalone/";
        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
