using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;

    public GameObject[] thrusterLights;

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
            thrusterLights[2].SetActive(true);
        }

        if (Input.GetKey(KeyCode.S) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(-transform.up * thrust);
            thrusterLights[0].SetActive(true);
        }

        if (Input.GetKey(KeyCode.A) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(-transform.right * thrust);
            thrusterLights[1].SetActive(true);
        }

        if (Input.GetKey(KeyCode.D) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(transform.right * thrust);
            thrusterLights[3].SetActive(true);
        }

        else
        {
            keyPressed = false;

            //thrusterLights[0].SetActive(false);
            thrusterLights[1].SetActive(false);
            //thrusterLights[2].SetActive(false);
            thrusterLights[3].SetActive(false);
        }
    }
}
