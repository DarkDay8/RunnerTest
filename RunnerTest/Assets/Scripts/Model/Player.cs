using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public Action<Vector3> ChangeForce;

    private PlayerView player;
    private int score = 0;
    private byte line = 1;
    private const byte MAXLINE = 3;
    private const float LINEDISTANGE = 2;
    private float speedZ = 3;
    private float speedX = 1;

    private Vector3 force;
    private bool changingLine = false;

    public Player(PlayerView player)
    {
        this.player = player;
        force = new Vector3(speedX, 0, 0);
    }

    public void MeveLeft()
    {
        if (line > 0 && !changingLine)
        {
            ChangeLine(speedZ);
            line--;
        }

    }
    public void MeveRight()
    {
        if (line < MAXLINE - 1 && !changingLine)
        {
            ChangeLine(-speedZ);
            line++;
        }

    }

    private void ChangeLine(float speed)
    {
        force = new Vector3(speedX, 0, speed);
        changingLine = true;
        ChangeForce(force);
    }

    public void CheckPosition(Vector3 position)
    {
        if (Mathf.Abs(position.z - (line - 1) * -LINEDISTANGE) < 0.03f && changingLine)
        {
            Debug.Log("Stop");
            force = new Vector3(speedX, 0, 0);
            changingLine = false;
            ChangeForce(force);
        }


    }
}
