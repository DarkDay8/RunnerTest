using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController
{
    private EndGameView view;
    private int totalScore;

    public EndGameController(int totalScore)
    {
        this.totalScore = totalScore;
        view = ViewController.LoadView(ViewesEnum.EndGame) as EndGameView;
        view.SetScoreValue(this.totalScore);
        view.SetExitAction(StartMenu);
    }

    private void StartMenu()
    {
        MenuController gameController = new MenuController();
        ViewController.RemoveView(ViewesEnum.EndGame);
    }
}
