using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public Rigidbody rb;
    public float SidewaysForce = 50f;

    void FixedUpdate()
    {
        // Right
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Vector3 faceRight = new Vector3(0, 0, 90);
            transform.eulerAngles = faceRight;
        }

        // Left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Vector3 faceLeft = new Vector3(0, 0, 270);
            transform.eulerAngles = faceLeft;
        }
        
        // Up
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, SidewaysForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            Vector3 faceUp = new Vector3(0, 0, 0);
            transform.eulerAngles = faceUp;
        }

        // Down
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -SidewaysForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            Vector3 faceDown = new Vector3(0, 0, 180);
            transform.eulerAngles = faceDown;
        }
    }
}