using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement_test : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    float lastXPos = 0f;
    float YPos = 0f;
    public float fallSpeed;

    // Update is called once per frame
    void Update()
    {

        YPos = transform.position.y;

        if (lastXPos == transform.position.x)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (fallSpeed * Time.deltaTime), transform.position.z);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp(0, 1,movementDirection.magnitude);
        movementDirection.Normalize();


        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);

        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        lastXPos = transform.position.x;
        

    }
}
