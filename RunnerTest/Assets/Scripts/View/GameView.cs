using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour, IView
{
    [SerializeField]
    private PlayerView player;    
    [SerializeField]
    private Vector3 distanse;

    private Vector3 direction;
    private new Camera camera;
    private Rigidbody playerRB;
    private bool stranting = false;

    public Action Left;
    public Action Right;
    public Func<float> Up;
    public Action Run;
    public Action<Vector3> UpdatePosition;



    void Start()
    {
        camera = Camera.main;
        playerRB = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdatePosition(player.transform.position);

        if (Input.GetKeyDown(KeyCode.A))
            Left();
        if (Input.GetKeyDown(KeyCode.D))
            Right();
        if (Input.GetKeyDown(KeyCode.W))
            playerRB.velocity += Vector3.up * Up();



        if (Input.anyKey && !stranting)
            Run();

        Vector3 newVelosity = new Vector3(direction.x, playerRB.velocity.y, direction.z);

        playerRB.velocity = newVelosity;
        camera.transform.position = new Vector3(
            player.transform.position.x, 
            player.transform.position.y, 
            0) + distanse;
    }

    public PlayerView GetPlayer()
    {
        return player;
    }
    public void SetForce(Vector3 d)
    {
        direction = d;
    }


}
