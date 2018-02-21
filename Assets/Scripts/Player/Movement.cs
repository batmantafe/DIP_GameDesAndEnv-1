using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;

    private bool keyPressed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        keyPressed = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(transform.up * thrust);
        }

        if (Input.GetKey(KeyCode.S) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(-transform.up * thrust);
        }

        if (Input.GetKey(KeyCode.A) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(-transform.right * thrust);
        }

        if (Input.GetKey(KeyCode.D) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(transform.right * thrust);
        }

        else
        {
            keyPressed = false;
        }
    }
}
