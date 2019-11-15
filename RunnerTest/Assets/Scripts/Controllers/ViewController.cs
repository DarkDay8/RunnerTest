using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    private static  Dictionary<string, GameObject> viewes;

    public static IView LoadView(string path)
    {
        var view = Instantiate(Resources.Load(path) as GameObject);
        if (viewes == null)
            viewes = new Dictionary<string, GameObject>();
        viewes.Add(path, view);
        return view.GetComponent<IView>();

    }
    public static bool RemoveView(string path)
    {
        Destroy(viewes[path]?.gameObject);
        return viewes.Remove(path);
    }
    public static void RemoveAllViewes()
    {
        foreach (var item in viewes)
            Destroy(item.Value);
        viewes = null;
    }
}
