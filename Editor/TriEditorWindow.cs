using UnityEngine;
using UnityEditor;

public class TriEditorWindow : EditorWindow
{
    
    public string[] toolbarStrings = new string[] { "go", "", "","" };
    public int toolbarInt = 0;

    public GameObject go;


    //[MenuItem("Window/AI Tool")]
    public static void ShowWindow()
    {
        GetWindow<TriEditorWindow>("AI");
    }

    private void OnGUI()
    {
        toolbarStrings = new string[go.GetComponent<List>().statelist.Length];
        Change(go);
        toolbarInt = GUI.Toolbar(new Rect(0, 0, 900, 50), toolbarInt, toolbarStrings, EditorStyles.toolbarButton);

        switch (toolbarInt)
        {
            case 0:
                Affichage(toolbarInt);
                break;
            case 1:
                Affichage(toolbarInt);
                break;
            case 2:
                Affichage(toolbarInt);
                break;
            case 3:
                Affichage(toolbarInt);
                break;
            case 4:
                Affichage(toolbarInt);
                break;
            case 5:
                Affichage(toolbarInt);
                break;
            case 6:
                Affichage(toolbarInt);
                break;
            case 7:
                Affichage(toolbarInt);
                break;
            case 8:
                Affichage(toolbarInt);
                break;
            case 9:
                Affichage(toolbarInt);
                break;
            case 10:
                Affichage(toolbarInt);
                break;
            case 11:
                Affichage(toolbarInt);

                break;
        }


        //GUILayout.Label("go");

        GUILayout.Space(5);
      

        //if (GUILayout.Button("Refresh"))
        //{

        //}
    }

    private void Affichage(int x)
    {
        GUILayout.Space(30);
        GUILayout.BeginHorizontal();

        EditorStyles.boldLabel.normal.textColor = Color.Lerp(Color.red, Color.green, 0.37f);
        GUILayout.Label("Actions: ", EditorStyles.boldLabel);
        EditorStyles.boldLabel.normal.textColor = Color.black;

        GUILayout.BeginVertical();
        for (int i = 0; i < go.GetComponent<List>().statelist[x].actions.Length; i++)
        {
            GUILayout.Label(("-  ") + go.GetComponent<List>().statelist[x].actions[i].ToString(), EditorStyles.boldLabel);
        }
        GUILayout.EndVertical();
        GUILayout.EndHorizontal();
        for (int a = 0; a < go.GetComponent<List>().statelist[x].transition.Length; a++)
        {
            GUILayout.Space(6);

            EditorStyles.boldLabel.normal.textColor = Color.Lerp(Color.red, Color.green, 0.37f);
            GUILayout.Label("Transition: " + (a + 1), EditorStyles.boldLabel);
            EditorStyles.boldLabel.normal.textColor = Color.black;

            GUILayout.BeginHorizontal();
            EditorStyles.boldLabel.normal.textColor = Color.Lerp(Color.red, Color.green, 0.37f);
            GUILayout.Label(" ", EditorStyles.boldLabel, GUILayout.MaxWidth(200));
            EditorStyles.boldLabel.normal.textColor = Color.black;

            GUILayout.Label(go.GetComponent<List>().statelist[x].transition[a].decision.name, EditorStyles.boldLabel);
            GUILayout.EndHorizontal();


            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            EditorStyles.boldLabel.normal.textColor = Color.Lerp(Color.red, Color.blue, 0.37f);
            GUILayout.Label("       TrueState: ", EditorStyles.boldLabel);
            EditorStyles.boldLabel.normal.textColor = Color.black;
            GUILayout.Label("       " + go.GetComponent<List>().statelist[x].transition[a].trueState.name, EditorStyles.boldLabel);
            GUILayout.EndVertical();
            GUILayout.BeginVertical();
            EditorStyles.boldLabel.normal.textColor = Color.Lerp(Color.red, Color.blue, 0.37f);
            GUILayout.Label("       FalseState: ", EditorStyles.boldLabel);
            EditorStyles.boldLabel.normal.textColor = Color.black;
            GUILayout.Label("       " + go.GetComponent<List>().statelist[x].transition[a].falseState.name, EditorStyles.boldLabel);
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }
    }

    private void Change(GameObject obj)
    {

        for (int i = 0; i < obj.GetComponent<List>().statelist.Length; i++)
        {
            toolbarStrings[i] = obj.GetComponent<List>().statelist[i].name;
        }
    }

}
