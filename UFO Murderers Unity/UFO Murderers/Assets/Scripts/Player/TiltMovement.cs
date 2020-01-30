using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMovement : MonoBehaviour
{ 
    //used to modify the tilt speed in the options menu    
    public static float tiltSpeed = 1;

    // Update is called once per frame
    void FixedUpdate()
    {
       transform.Translate(0, 0, -Input.acceleration.x * tiltSpeed);

    }
}