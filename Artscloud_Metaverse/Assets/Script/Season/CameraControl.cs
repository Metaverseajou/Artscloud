using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
   [SerializeField]
    float moveSpeed = 2.0f;
    float gravity = -20f;
    float yVelocity = 0;
    Vector3 moveDirection;

    public Transform cameraTransform;
    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(x, 0, z);
        moveDirection = cameraTransform.TransformDirection(moveDirection) * moveSpeed;

        if (characterController.isGrounded)
        {
            yVelocity = 0;
        }
        yVelocity += (gravity * Time.deltaTime);
        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}