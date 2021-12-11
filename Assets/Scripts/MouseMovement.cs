using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSpeed = 12f;
    Vector3 velocity;
    public CharacterController mouseController;
    PlayerMovement PlayerMovement;
    GameObject player;
    float gravity;
    public int ogwill = 10000;
    public int will;
    public int DeadCount = 0;

    void Start()
    {
        player = GameObject.Find("Player");
        PlayerMovement = player.GetComponent<PlayerMovement>();
        gravity = PlayerMovement.gravity;
        will = ogwill;
    }

    void Update()
    {
        if (PlayerMovement.whoPlays == false) { 
        velocity.y += gravity * Time.deltaTime;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        mouseController.Move(move * mouseSpeed * Time.deltaTime);
        mouseController.Move(velocity * Time.deltaTime);
        }
        if (will <= 0 && DeadCount==1)
        {
            Debug.Log("ded");
            DeadCount++;
        }

    }

    public void takeDamage (int damages) {
        will -= damages;
    }
}
