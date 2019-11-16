using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour, IView
{
    [SerializeField]
    private Rigidbody player;
    [SerializeField]
    private Vector3 distanse;

    private new Camera camera;

    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        player.AddForce(Vector3.right);
        camera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0) + distanse;
    }
}
