using UnityEngine;
using UnityEditor;

public class TagEditorWindow : EditorWindow {

    public Vector2 scrollPosition;

    //[MenuItem("Window/Tag")]
    public static void ShowWindow()
    {
        GetWindow<TagEditorWindow>("Tag Viewer");

    }

    private void OnGUI()
    {
        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(3000), GUILayout.Height(500));

        foreach (GameObject obj in Selection.gameObjects)
        {
            GUILayout.BeginHorizontal();

            //GUILayout.Label("-----------------------------------------------", EditorStyles.boldLabel);

            //GUILayout.BeginHorizontal();
            EditorStyles.boldLabel.normal.textColor = Color.blue;
            GUILayout.Label("Name: ", EditorStyles.boldLabel, GUILayout.MaxWidth(60));
            EditorStyles.boldLabel.normal.textColor = Color.black;
            string name = EditorGUILayout.TextField(obj.name, EditorStyles.textField, GUILayout.MaxWidth(100));
            obj.name = name;
            //GUILayout.EndHorizontal();


            //GUILayout.BeginHorizontal();
            EditorStyles.boldLabel.normal.textColor = Color.Lerp(Color.red, Color.green, 0.37f);
            GUILayout.Label("Tag: " , EditorStyles.boldLabel, GUILayout.MaxWidth(60));
            EditorStyles.boldLabel.normal.textColor = Color.black;

            string tag = EditorGUILayout.TagField( obj.tag, EditorStyles.textField, GUILayout.MaxWidth(100));
            obj.tag = tag;
            GUILayout.EndHorizontal();

            
            //GUILayout.BeginVertical();
            //GUILayout.BeginHorizontal();

            //GUILayout.Label("Actived: ", EditorStyles.boldLabel, GUILayout.MaxWidth(100));
            //bool act = EditorGUILayout.Toggle("", obj.activeSelf, EditorStyles.toggleGroup, GUILayout.MaxWidth(100));
            //obj.SetActive(act);
            //GUILayout.EndHorizontal();

            //GUILayout.BeginHorizontal();
            //GUILayout.Label("Protected: ", EditorStyles.boldLabel, GUILayout.MaxWidth(100));
            //EditorGUILayout.Toggle("", obj.activeSelf, EditorStyles.toggleGroup, GUILayout.MaxWidth(100));
            //GUILayout.EndHorizontal();

            //GUILayout.BeginHorizontal();
            //GUILayout.Label("Grabbed: ", EditorStyles.boldLabel, GUILayout.MaxWidth(100));
            //EditorGUILayout.Toggle("", obj.activeSelf, EditorStyles.toggleGroup, GUILayout.MaxWidth(100));
            //GUILayout.EndHorizontal();

            //GUILayout.EndVertical();

            //GUILayout.EndHorizontal();




            GUILayout.Space(2);
        }

        GUILayout.EndScrollView();

        if (GUILayout.Button("Refresh"))
        {

        }

    }
    void OnSelectionChange()
    {
        Repaint();
    }

}
