using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController
{
    private string viewPath = "Prefabs/View/Menu";
    private MenuView view;

    public MenuController()
    {
        view = ViewController.LoadView(viewPath) as MenuView;
        view.ChangeText("Testing");
    }
}
