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
        Vector3 move = Camera.main.transform.right * horizontalInput + Camera.main.transform.forward * verticalInput;
        move = new Vector3 (move.x, -9.5f, move.z);

        //mouse movement
        charController.Move(move * speed * Time.deltaTime);

        transform.rotation = Quaternion.Euler(new Vector3(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, Camera.main.transform.rotation.eulerAngles.z));
    }
}
