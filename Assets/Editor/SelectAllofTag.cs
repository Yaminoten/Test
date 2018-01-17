using UnityEngine;
using UnityEditor;

class SelectAllOfTag : EditorWindow
{
    //[MenuItem("Window/TagSelector")]
    public static void ShowWindow()
    {
        GetWindow<SelectAllOfTag>("Tag Selector");

    }

    public string tagName = "";

    private void OnGUI()
    {
        tagName = EditorGUILayout.TagField(tagName,EditorStyles.textField, GUILayout.MaxWidth(100));

        if (GUILayout.Button("Select"))
        {
            GameObject[] gos = GameObject.FindGameObjectsWithTag(tagName);
            Selection.objects = gos;
        }
    }

    void SelectChange()
    {
        
    }
}