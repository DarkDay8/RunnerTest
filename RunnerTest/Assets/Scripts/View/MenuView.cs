using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuView : MonoBehaviour, IView
{
    [SerializeField]
    private Text text1;

    public void ChangeText(string text)
    {
        text1.text = text;
    }

}
