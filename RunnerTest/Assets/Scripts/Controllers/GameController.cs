using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private GameView view;
    private Section section;

    public GameController()
    {
        section = new Section();
        view = ViewController.LoadView(ViewesEnum.Game) as GameView;
    }
}
