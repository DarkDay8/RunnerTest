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
        view.SetStartBtnAction(StartGame);
    }

    private void StartGame()
    {
        GameController gameController = new GameController();
        ViewController.RemoveView(viewPath);
    }
}
