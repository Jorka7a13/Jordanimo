using UnityEditor.SceneManagement;

public class SceneChanger
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Scene/Test")]
    private static void TestScene()
    {
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        EditorSceneManager.OpenScene("Assets/Scenes/Test.unity");
    }

    [UnityEditor.MenuItem("Scene/EnvironmentTest")]
    private static void EnvironmentTestScene()
    {
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        EditorSceneManager.OpenScene("Assets/Scenes/EnvironmentTest.unity");
    }
#endif
}