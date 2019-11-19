using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    private static  Dictionary<ViewesEnum, GameObject> viewes;

    //Cann't instance some same view 
    public static IView LoadView(ViewesEnum viewEnum)
    {
        var view = Instantiate(Resources.Load(EnumContoller.GetPath(viewEnum)) as GameObject);
        if (viewes == null)
            viewes = new Dictionary<ViewesEnum, GameObject>();
        viewes.Add(viewEnum, view);
        return view.GetComponent<IView>();

    }
    public static bool RemoveView(ViewesEnum viewEnum)
    {
        Destroy(viewes[viewEnum]?.gameObject);
        return viewes.Remove(viewEnum);
    }
    public static void RemoveAllViewes()
    {
        foreach (var item in viewes)
            Destroy(item.Value);
        viewes = null;
    }

    public static GameObject LoadSection(SectionEnum sectioEnum, ref float distanse)
    {
        //now section size is const.
        //we need build correct section prefab
        const float SIZE = 10; 
        GameObject go = Instantiate(Resources.Load(EnumContoller.GetPath(sectioEnum)) as GameObject,
            new Vector3(distanse, 0, 0), Quaternion.identity);
        distanse += SIZE;
        return go;
    }
    public static void DestoyGameObject(GameObject gameObject)
    {
        Destroy(gameObject);
    }

}
