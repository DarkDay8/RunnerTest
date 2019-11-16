using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    private static  Dictionary<ViewesEnum, GameObject> viewes;

    //Cann't instance some same view 
    public static IView LoadView(ViewesEnum ViewEnum)
    {
        var view = Instantiate(Resources.Load(ViewPathEnum.GetPath(ViewEnum)) as GameObject);
        if (viewes == null)
            viewes = new Dictionary<ViewesEnum, GameObject>();
        viewes.Add(ViewEnum, view);
        return view.GetComponent<IView>();

    }
    public static bool RemoveView(ViewesEnum ViewEnum)
    {
        Destroy(viewes[ViewEnum]?.gameObject);
        return viewes.Remove(ViewEnum);
    }
    public static void RemoveAllViewes()
    {
        foreach (var item in viewes)
            Destroy(item.Value);
        viewes = null;
    }
}
