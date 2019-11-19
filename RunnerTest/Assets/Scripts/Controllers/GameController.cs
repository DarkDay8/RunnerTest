using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private GameView view;
    private Section section;
    private Player player;

    public GameController()
    {
        view = ViewController.LoadView(ViewesEnum.Game) as GameView;
        section = new Section();
        player = new Player(view.GetPlayer());
        SetActions();
        ChangeMoveForce(Vector3.right);
    }
    public void SetActions()
    {
        player.ChangeForce = ChangeMoveForce;
        view.Right = player.MeveRight;
        view.Left = player.MeveLeft;
        view.UpdatePosition = player.CheckPosition;

    }

    private void ChangeMoveForce(Vector3 force)
    {
        view.SetForce(force);
    }
}
