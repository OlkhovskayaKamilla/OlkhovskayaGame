using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    private Camera TheCamera;
    public Camera Cam;

    void Start()
    {
        TheCamera = GetComponent<Camera>();
        TheCamera = Camera.main;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TheCamera.enabled = !TheCamera.enabled;
            Cam.enabled = !Cam.enabled;
        }

    }
}

