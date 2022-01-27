using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hunter : Player, IJump
{

    public float jumpHeight;
    Controls controls;
    public Transform groundCheck;
    public LayerMask groundMask;
    Vector2 movement, camerarotation;
    public Camera myCamera;
    public CameraMovement cameramovement;
    void Awake()
    {
        controls = new Controls();
    }
    void Update() {

        if (gameManager.hunterIsPlaying && !gameManager.isGameFinished) {

            controls.Player.move.performed += ctx => movement = ctx.ReadValue<Vector2>() ;
            Move(movement);
            controls.Player.Jump.performed += ctx => Jump();
            Fall();
            controls.Player.camera.performed += ctx => camerarotation = ctx.ReadValue<Vector2>() ;
            cameramovement.CameraMove(camerarotation);
            controller.Move(velocity * Time.deltaTime);


        }
    }

    public void Jump() {

        if (Input.GetButton("Jump") && IsGrounded())
            velocity.y = jumpHeight;
    }

    public bool IsGrounded() => Physics.CheckSphere(groundCheck.position, 0.4f, groundMask);

}
