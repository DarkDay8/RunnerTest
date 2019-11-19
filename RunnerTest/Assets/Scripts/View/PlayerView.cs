using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField]
    private string wallTag = "Wall";
    [SerializeField]
    private string roadTag = "Road";
    [SerializeField]
    private string CheckTag = "Checkpoint";
    public Action wall;
    public Action road;
    public Action checkpoint;
    public Action<int> coins;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(wallTag))
            wall();
        if (collision.gameObject.tag.Equals(roadTag))
            road();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(CheckTag))
            checkpoint();
    }


}
