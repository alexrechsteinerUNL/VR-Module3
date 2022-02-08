using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Orbit_Pickup : MonoBehaviour
{
    public float speed = 5.0f;
    public float r;
    public float x;
    public float y;
    public float ANGLE = 0;


    private int direction = 1;

    // Update is called once per frame
    void Update()
    {
        r = 7.39f;
        ANGLE = ANGLE + 0.001f;
        x = r * Mathf.Sin(ANGLE);
        y = r * Mathf.Cos(ANGLE);
        transform.position = new Vector3(x, .75f, y);

    }
}
