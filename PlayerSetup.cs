using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerMovement))]
public class PlayerSetup : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        PlayerMovement pmvmt = (PlayerMovement)target;
        GUILayout.Space(10);
        if (GUILayout.Button("Setup Player"))
            pmvmt.setupCharacter();
    }

}