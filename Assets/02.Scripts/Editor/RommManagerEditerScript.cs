using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RoomManager))]
public class RommManagerEditerScript : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        EditorGUILayout.HelpBox("This script is responsbile for connecting to Photon Servers.", MessageType.Info);

        RoomManager roomManager = (RoomManager)target;

        if (GUILayout.Button("·£´ý·ë ¸ÅÄª"))
        {
            roomManager.JoinRandomRoom();
        }
    }
}
