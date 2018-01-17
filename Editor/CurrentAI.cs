using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CurrentAI : EditorWindow
{
    //[MenuItem("Window/CurrentAI State")]
    public static void ShowWindow()
    {
        GetWindow<CurrentAI>("Current State");
    }

    private void OnGUI()
    {
        GameObject[] gos = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in gos)
        {

            if (obj.gameObject.GetComponent<StatesController>() != null && obj.gameObject != null)
            {
                GUILayout.BeginHorizontal();

                EditorStyles.boldLabel.normal.textColor = Color.Lerp(Color.red, Color.green, 0.37f);
                GUILayout.Label("Name: ", EditorStyles.boldLabel, GUILayout.MaxWidth(60));
                EditorStyles.boldLabel.normal.textColor = Color.black;
                string name = EditorGUILayout.TextField(obj.name, EditorStyles.boldLabel, GUILayout.MaxWidth(100));
                obj.name = name;

                EditorStyles.boldLabel.normal.textColor = Color.Lerp(Color.red, Color.green, 0.37f);
                GUILayout.Label("State: ", EditorStyles.boldLabel, GUILayout.MaxWidth(60));
                EditorStyles.boldLabel.normal.textColor = Color.black;
               GUILayout.Label(obj.gameObject.GetComponent<StatesController>().CurrentState.name, EditorStyles.boldLabel, GUILayout.MaxWidth(100));
                
                
                GUILayout.EndHorizontal();
            } 
        }
    }
    private void OnInspectorUpdate()
    {
        Repaint();
    }
}
