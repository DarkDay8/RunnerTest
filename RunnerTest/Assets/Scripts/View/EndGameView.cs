using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EndGameView : MonoBehaviour, IView
{ 
    [SerializeField]
    private Text scoreValue;
    [SerializeField]
    private Button exitButton;

    public void SetScoreValue(int value)
    {
        scoreValue.text = value.ToString();
    }

    public void SetExitAction(UnityAction action)
    {
        exitButton.onClick.AddListener(action);
    }

}
