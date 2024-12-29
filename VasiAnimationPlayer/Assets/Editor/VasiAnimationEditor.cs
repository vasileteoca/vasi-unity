using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(VasiAnimation))]
public class VasiAnimationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        VasiAnimation vasiAnimation = (VasiAnimation)target;

        DrawDefaultInspector();

        if (GUILayout.Button("Load Animation"))
        {
            string path = EditorUtility.OpenFilePanel("Load .vasi Animation", "", "vasi");
            if (!string.IsNullOrEmpty(path))
            {
                vasiAnimation.LoadAnimation(path);
            }
        }

        if (GUILayout.Button("Play Animation"))
        {
            vasiAnimation.PlayAnimation();
        }
    }
}