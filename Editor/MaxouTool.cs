using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MaxouTool : EditorWindow {
    public Texture2D text;

    [MenuItem("Window/Max Tool")]
    public static void ShowWindow()
    {
        GetWindow<MaxouTool>("Max Tools");
        
    }

    private void OnGUI()
    {


        GUI.DrawTexture(new Rect(0, 0, 576, 284), text);

        GUILayout.Space(80);
        EditorStyles.boldLabel.fontSize = 40;
        EditorStyles.boldLabel.normal.textColor = Color.white;
        GUILayout.Label("Max Tool's", EditorStyles.boldLabel);
        EditorStyles.boldLabel.normal.textColor = Color.black;
        EditorStyles.boldLabel.fontSize = 11;

        Color defaultColor = GUI.color;
        GUI.color = Color.white;        

        GUILayout.BeginVertical();
        GUILayout.Space(50);
        if (GUILayout.Button("Tag Selector", EditorStyles.miniButton, GUILayout.MaxWidth(150)))
        {
            GetWindow<SelectAllOfTag>();
        }
        if (GUILayout.Button("Tag Viewer", EditorStyles.miniButton, GUILayout.MaxWidth(150)))
        {
            GetWindow<TagEditorWindow>();
        }
        if (GUILayout.Button("State Viewer", EditorStyles.miniButton, GUILayout.MaxWidth(150)))
        {
            GetWindow<CurrentAI>();
        }

        if (GUILayout.Button("Bool Checker", EditorStyles.miniButton, GUILayout.MaxWidth(150)))
        {
            GetWindow<BooleanCheck>();
        }
        if (GUILayout.Button("AI Tool", EditorStyles.miniButton, GUILayout.MaxWidth(150)))
        {
            GetWindow<TriEditorWindow>();
        }
        GUILayout.EndVertical();

        GUI.color = defaultColor;
    }
}
