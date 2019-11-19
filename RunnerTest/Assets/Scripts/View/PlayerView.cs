using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private const string wallTag = "Wall";
    private const string roadTag = "Road";
    private const string checkTag = "Checkpoint";
    private const string bonusTag = "Bonus";

    public Action wall;
    public Action road;
    public Action checkpoint;
    public Action<int> coins;

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case wallTag:
                wall();
                break;
            case roadTag:
                road();
                break;
            case bonusTag:
                TakeBonus(collision.gameObject);
                break;
            default:
                break;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(checkTag))
            checkpoint();
    }

    private void TakeBonus(GameObject go)
    {
        int coinbonus = 10;
        if (go.name.Contains("coin"))
            coins(coinbonus);
        Destroy(go);
    }


}
