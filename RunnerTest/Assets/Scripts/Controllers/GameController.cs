using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private string viewPath = "Prefabs/View/Game";
    private GameView view;

    public GameController()
    {
        view = ViewController.LoadView(viewPath) as GameView;
    }
}
