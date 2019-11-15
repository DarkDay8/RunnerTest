using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuView : MonoBehaviour, IView
{
    [SerializeField]
    private Text text1;
    [SerializeField]
    private Button start_btn;
    [SerializeField]
    private Button exit_btn;

    public void SetStartBtnAction(UnityAction action)
    {
        start_btn.onClick.AddListener(action);
    }

    public void Start()
    {
        exit_btn.onClick.AddListener(() => Application.Quit());
    }
}
