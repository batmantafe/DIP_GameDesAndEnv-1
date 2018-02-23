using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;

    public GameObject botLight, topLight, leftLight, rightLight;
    
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

        Shortcuts();
    }

    void Move()
    {
        // Player presses Up
        if (Input.GetKey(KeyCode.W) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(transform.up * thrust);

            topLight.GetComponent<Light>().enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            topLight.GetComponent<Light>().enabled = false;
        }

        // Player presses Down
        if (Input.GetKey(KeyCode.S) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(-transform.up * thrust);

            botLight.GetComponent<Light>().enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            botLight.GetComponent<Light>().enabled = false;
        }

        // Player presses Left
        if (Input.GetKey(KeyCode.A) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(-transform.right * thrust);

            leftLight.GetComponent<Light>().enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            leftLight.GetComponent<Light>().enabled = false;
        }

        // Player presses Right
        if (Input.GetKey(KeyCode.D) && keyPressed == false)
        {
            keyPressed = true;
            rb.AddForce(transform.right * thrust);

            rightLight.GetComponent<Light>().enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rightLight.GetComponent<Light>().enabled = false;
        }

        else
        {
            keyPressed = false;
        }
    }

    void Shortcuts()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }

        if (Input.GetKey(KeyCode.F1))
        {
            //SceneManager.LoadScene("Menu");
        }
    }

    /*void OnColliderEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Lose");
        }
    }*/
}
