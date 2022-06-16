using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterMovement : MonoBehaviour
{
    CharacterController characterController;
    public float MovementSpeed = 1;
    private Camera cam;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        cam = Camera.main;
    }

    void Update()
    {
        // player movement - forward, backward, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move((transform.right * horizontal + transform.forward * vertical) * Time.deltaTime);


    }
}
