using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables
    private CharacterController charController;
    public float speed;
    private float horizontalInput;
    private float verticalInput;



    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMovement();
    }

    void CharacterMovement()
    {
        //call horizontal & vertical inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move horizontal & vertical
        Vector3 move = transform.right * horizontalInput + transform.forward * verticalInput;

        //mouse movement
        charController.Move(move * speed * Time.deltaTime);
    }
}
