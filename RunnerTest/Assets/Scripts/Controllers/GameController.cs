using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private GameView view;

    public GameController()
    {
        view = ViewController.LoadView(ViewesEnum.Game) as GameView;
    }
}
