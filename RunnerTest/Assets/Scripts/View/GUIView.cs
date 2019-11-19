using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIView : MonoBehaviour
{
    [SerializeField]
    private Text scoreValue;

    public void SetScoreValue(int value)
    {
        scoreValue.text = value.ToString();
    }
}
