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

    void Start () {
        player = GameObject.Find("Player");
        PlayerMovement = player.GetComponent<PlayerMovement>();
        gravity = PlayerMovement.gravity;

    }

    void Update () {
        
        if (PlayerMovement.whoPlays == false) {

            velocity.y += gravity * Time.deltaTime;
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            Vector3 move = transform.right * x + transform.forward * z;

            mouseController.Move(move * mouseSpeed * Time.deltaTime);
            mouseController.Move(velocity * Time.deltaTime);
        }
    }


}
