using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POVMenu : MonoBehaviour
{
    public Transform POV;
    public float mouseSensitivity = 2f;
    float cameraVertRotation = 0f;
    

    void Start()
    {
        //Locks the cursor to the center of the screen and makes it invisible
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        //Collect the mouse inputs
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        //Rotate the camera around x-axis
        cameraVertRotation -= inputY;
        cameraVertRotation = Mathf.Clamp(cameraVertRotation, -45f, 45f);
        transform.localEulerAngles = Vector3.right * cameraVertRotation;

        //Rotate around y-axis using the sphere created
        POV.Rotate(Vector3.up * inputX);

    }
        
        
}
