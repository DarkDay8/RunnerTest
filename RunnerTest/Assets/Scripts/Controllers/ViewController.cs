using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    private static  Dictionary<string, GameObject> scenes;

    public static IView LoadView(string path)
    {
        var view = Instantiate(Resources.Load(path) as GameObject);
        if (scenes == null)
            scenes = new Dictionary<string, GameObject>();
        scenes.Add(path, view);
        return view.GetComponent<IView>();

    }
    public static void RemoveView(string path)
    {

    }
    public static void ClearAllViewes()
    {

    }

}
