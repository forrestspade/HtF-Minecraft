using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5;
    public float jumpPower = 5;
    public float gravity = 15;

    float maxFallSpeed = -8;
    float yMovement;

    private void Update()
    {
        // Get movement input
        Vector3 moveVector = Vector3.zero;
        moveVector += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        moveVector += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Apply gravity
        yMovement -= gravity * Time.deltaTime;
        if (yMovement < maxFallSpeed || controller.isGrounded)
        {
            yMovement = maxFallSpeed;
        }

        // Get jump input
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            yMovement = 5f;
        }
        moveVector.y = yMovement * Time.deltaTime;

        // Move character
        controller.Move(moveVector);
    }
}
