using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController
{
    private MenuView view;

    public MenuController()
    {
        view = ViewController.LoadView(ViewesEnum.Menu) as MenuView;
        view.SetStartBtnAction(StartGame);
    }

    private void StartGame()
    {
        GameController gameController = new GameController();
        ViewController.RemoveView(ViewesEnum.Menu);
    }
}
