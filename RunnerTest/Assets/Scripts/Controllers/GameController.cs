using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    private GameView view;
    private GUIView gui;
    private Section section;
    private Player player;

    public GameController()
    {
        view = ViewController.LoadView(ViewesEnum.Game) as GameView;
        gui = ViewController.LoadView(ViewesEnum.GameGUI) as GUIView;

        section = new Section();
        player = new Player(view.GetPlayer());
        SetActions();
    }
    public void SetActions()
    {
        player.ChangeForce = ChangeMoveForce;
        view.Right = player.MeveRight;
        view.Left = player.MeveLeft;
        view.Up = player.Jump;
        view.UpdatePosition = player.CheckPosition;
        view.GetPlayer().checkpoint = section.UpdateSections;
        view.Run = Run;
        view.SpeedAcceleration = player.SpeedAcceleration;
        player.ChangeGUI = gui.SetScoreValue;
        view.GetPlayer().wall = EndGame;
    }

    private void EndGame()
    {
        section.RemoveAllSections();
        ViewController.RemoveAllViewes();
        EndGameController endGame = new EndGameController(player.GetScore());

    }

    private void Run()
    {
        view.SetForce(player.GetForse());
    }

    private void ChangeMoveForce(Vector3 force)
    {
        view.SetForce(force);
    }


}
