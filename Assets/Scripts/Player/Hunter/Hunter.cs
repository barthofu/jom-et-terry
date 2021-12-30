using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : Player, IJump
{

    public float jumpHeight;

    public Transform groundCheck;
    public LayerMask groundMask;


    void Update() {

        if (gameManager.hunterIsPlaying && !gameManager.isGameFinished) {

            Move();
            Jump();
            Fall();

            controller.Move(velocity * Time.deltaTime);
        }
    }

    public void Jump() {

        if (Input.GetButton("Jump") && IsGrounded())
            velocity.y = jumpHeight;
    }

    public bool IsGrounded() => Physics.CheckSphere(groundCheck.position, 0.4f, groundMask);

}
