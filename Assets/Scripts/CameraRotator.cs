using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    float cameraSpeed = 200f;
    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(0, cameraSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(0, -cameraSpeed * Time.deltaTime, 0);
        }
    }
}
