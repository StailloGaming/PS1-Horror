using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    //variables
    public Transform playerBody; //transform camera with player body
    public float mouseSensitivity = 100f;
    private float xRotation = 0f;
  
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //lock mouse to not move out of screen
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        //call input access
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotation is flipped
        xRotation -= mouseY;

        //clamp rotation to not be able to look too high up
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //rotation
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //rotate body with camera
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
