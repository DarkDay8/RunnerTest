using UnityEngine;
using UnityEngine.UI;

public class GUIView : MonoBehaviour, IView
{ 
    [SerializeField]
    private Text scoreValue;

    public void SetScoreValue(int value)
    {
        scoreValue.text = value.ToString();
    }

}
