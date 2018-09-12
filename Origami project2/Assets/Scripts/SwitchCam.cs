using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{

    Camera cam1, cam2;

    bool IsCam1 = true;

    void Start()
    {
        cam1 = GameObject.Find("CameraOne").GetComponent<Camera>();
        cam2 = GameObject.Find("CameraTwo").GetComponent<Camera>();

        cam1.enabled = true;
        cam2.enabled = false;
    }

    void Update()
    {
        //Press the L Button to switch cameras
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            if (IsCam1)
            {
                cam1.enabled = false;
                cam2.enabled = true;
                IsCam1 = false;
            }
            else
            {
                cam1.enabled = true;
                cam2.enabled = false;
                IsCam1 = true;
            }
        }
    }
}
