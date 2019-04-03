using UnityEditor;
using UnityEditor.Build;

class AddXiaomiBundleIDPostfix : IPreprocessBuild
{
    public int callbackOrder { get { return 0; } }
    private const string XiaomiPostfix = ".mi"; // The postfix requested by Xiaomi.

    public void OnPreprocessBuild(BuildTarget target, string path)
    {
        // Check if the current package name has Xiaomi postfix.
        if (EditorUserBuildSettings.selectedBuildTargetGroup == BuildTargetGroup.Android && !PlayerSettings.applicationIdentifier.EndsWith(XiaomiPostfix))
            PlayerSettings.SetApplicationIdentifier(EditorUserBuildSettings.selectedBuildTargetGroup, PlayerSettings.applicationIdentifier + XiaomiPostfix);
    }
}
