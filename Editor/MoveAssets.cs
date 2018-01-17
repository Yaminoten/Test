using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveAssets : EditorWindow {

    public Object[] Item;
    public string path;

    public GameObject go;

    [MenuItem("Window/Move Assets")]
    public static void ShowWindow()
    {
        GetWindow<MoveAssets>("Move Assets");

    }

    private void OnGUI()
    {
        Item = new Object[go.GetComponent<List>().ObjectList.Length];
        Change(go);



        if (GUILayout.Button("Change"))
        {

            //AssetDatabase.RenameAsset("Assets/Sprites/ForceStatesController.cs", "Tavu.cs");
            //Debug.Log(path);
            //Debug.Log(Item.name);
            //Debug.Log(Item.GetType());


            foreach (Object obj in Item)
            {
                string path = AssetDatabase.GetAssetPath(obj);


                if (path.Contains(".cs"))
                {
                    AssetDatabase.MoveAsset(path, newPath: ("Assets/Scripts/" + obj.name + ".cs"));
                }

                if (path.Contains("wanna"))
                {
                    AssetDatabase.MoveAsset(path, newPath: ("Assets/Fbx/" + obj.name + ".jpg"));
                }
                //if (obj.GetType() == typeof(MonoScript))
                //{
                //    AssetDatabase.MoveAsset(path, newPath: ("Assets/Scripts/" + obj.name + ".cs"));
                //}

            }
            AssetDatabase.Refresh();
            //AssetDatabase.MoveAsset("Assets/Sprites/ForceStatesController.cs", newPath: "Assets/Fbx/ForceStatesController.cs");
        }

    }

    private void Change(GameObject obj)
    {

        for (int i = 0; i < obj.GetComponent<List>().ObjectList.Length; i++)
        {
            Item[i] = obj.GetComponent<List>().ObjectList[i];
        }
    }

}
