using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float speed;
    public int hp;
    public int deadCount = 0;
    Controls controls;
    public float gravity;
    protected CharacterController controller;
    protected Vector3 velocity = Vector3.zero;
    public GameManager gameManager;

    public void Start() {
        
        gameManager = GameObject.Find("_GameManager").GetComponent<GameManager>();
        gravity = gameManager.gravity;
        controller = GetComponent<CharacterController>();
    }
    void Awake()
    {
        controls = new Controls();
    }

    public void Move(Vector2 movement) {

        float x = movement.x;
        float z = movement.y;

        Vector3 move = transform.right * x + transform.forward * z;
        move *= speed;

        controller.Move(move * Time.deltaTime);
    }

    public void Fall() {

        velocity.y += gravity * Time.deltaTime;
    }

    
}
