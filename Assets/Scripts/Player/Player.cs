using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public int hp;
    public int deadCount = 0;

    public float gravity;
    protected CharacterController controller;
    protected Vector3 velocity = Vector3.zero;
    protected GameManager gameManager;

    public void Start() {
        
        gameManager = GameObject.Find("_GameManager").GetComponent<GameManager>();
        gravity = gameManager.gravity;
        controller = GetComponent<CharacterController>();
    }

    public void Move() {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        move *= speed;

        controller.Move(move * Time.deltaTime);
    }

    public void Fall() {

        velocity.y += gravity * Time.deltaTime;
    }

    
}
