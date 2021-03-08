using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Vector3 camOffset = new Vector3(0f, 1.2f, -2.6f);
    public Vector3 camOffsetTwo = new Vector3(0f, 1f, .5f);

    private Transform target;
    private int camMode;

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void LateUpdate()
    {
        if (Input.GetButtonDown("Camera"))
        {
            if (camMode == 1)
            {
                camMode = 0;
            }
            else
            {
                camMode += 1;
            }
        }
        if (camMode == 0)
        {
            this.transform.position = target.TransformPoint(camOffset);
            this.transform.LookAt(target);
        }
        if (camMode == 1)
        {
            this.transform.position = target.TransformPoint(camOffsetTwo);
        }
    }
}
