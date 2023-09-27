using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MiningWorldManager))]
public class MiningWorldTestEditor : Editor
{
    //attach to miningWorldmanager and press play to generate a new world
    //miningworldmanager cannot use singleton
    MiningWorldManager manager;
    private void OnSceneGUI()
    {
    manager = (MiningWorldManager)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Generate New World"))
        {
            manager.GenerateWorldEditor();
        }
    }
}
