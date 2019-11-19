using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public Action<Vector3> ChangeForce;
    public Action<int> ChangeGUI;

    private PlayerView player;
    private int score = 0;
    private byte line = 1;
    private const byte MAXLINE = 3;
    private const float LINEDISTANGE = 2;
    private float speedZ = 3;
    private float baseSpeedX = 2;
    private float accelerationSpeedX = 0.5f;
    private float jumpPower = 4;

    private float currectSpeedX;
    private Vector3 force;
    private bool changingLine = false;
    private bool onRoad = false;
    private bool left = false;
    private bool right = false;


    public Vector3 GetForse()
    {
        return force;
    }
    public void OnRoad()
    {
        onRoad = true;
    }
    public Player(PlayerView player)
    {
        this.player = player;
        player.road = OnRoad;
        player.coins = AddCoins;
        currectSpeedX = baseSpeedX;
        force = new Vector3(currectSpeedX, 0, 0);
    }
    public void SpeedAcceleration()
    {
        currectSpeedX += accelerationSpeedX;
        speedZ += accelerationSpeedX;
        Vector3 ac = new Vector3(accelerationSpeedX, 0, 0);
        force += ac;
        ChangeForce(force);
    }

    public void AddCoins(int coins)
    {
        score += coins;
        //ChangeGUI(score);
        Debug.Log("Score: " + score);
    }

    public void MeveRight()
    {
        if (line < MAXLINE - 1 && !changingLine)
        {
            ChangeLine(-speedZ);
            line++;
            right = true;
        }
    }
    public void MeveLeft()
    {
        if (line > 0 && !changingLine)
        {
            ChangeLine(speedZ);
            line--;
            left = true;
        }
    }
    public float Jump()
    {
        if (onRoad && !changingLine)
        {
            onRoad = false;
            changingLine = true;
            return jumpPower;
        }
        return 0;
    }
    private void ChangeLine(float speed)
    {
        force = new Vector3(currectSpeedX, 0, speed);
        changingLine = true;
        ChangeForce(force);
    }

    public void CheckPosition(Vector3 position)
    {
        if (!onRoad && !changingLine)
            return;

        if (position.z < (line - 1) * -LINEDISTANGE && left
            || position.z > (line - 1) * -LINEDISTANGE && right)
            return;
       
        Debug.Log("Stop");
        force = new Vector3(currectSpeedX, 0, 0);
        changingLine = left = right = false;
        ChangeForce(force);
    }
}
