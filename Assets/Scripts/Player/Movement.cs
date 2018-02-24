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

    public float moveCost;

    public GameObject botRocket, topRocket, leftRocket, rightRocket;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        keyPressed = false;

        moveCost = 10;

        Cursor.visible = false;
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
        if ((Input.GetKey(KeyCode.W) && keyPressed == false && HUD.playerFuel > 0)
            || (Input.GetKey(KeyCode.UpArrow) && keyPressed == false && HUD.playerFuel > 0))
        {
            keyPressed = true;
            rb.AddForce(transform.up * thrust);

            topLight.GetComponent<Light>().enabled = true;

            botRocket.GetComponent<Light>().enabled = true;

            FuelFunction();
        }

        if (Input.GetKeyUp(KeyCode.W)
            || Input.GetKeyUp(KeyCode.UpArrow))
        {
            topLight.GetComponent<Light>().enabled = false;

            botRocket.GetComponent<Light>().enabled = false;
        }

        // Player presses Down
        if ((Input.GetKey(KeyCode.S) && keyPressed == false && HUD.playerFuel > 0)
            || (Input.GetKey(KeyCode.DownArrow) && keyPressed == false && HUD.playerFuel > 0))
        {
            keyPressed = true;
            rb.AddForce(-transform.up * thrust);

            botLight.GetComponent<Light>().enabled = true;

            topRocket.GetComponent<Light>().enabled = true;

            FuelFunction();
        }

        if (Input.GetKeyUp(KeyCode.S)
            || Input.GetKeyUp(KeyCode.DownArrow))
        {
            botLight.GetComponent<Light>().enabled = false;

            topRocket.GetComponent<Light>().enabled = false;
        }

        // Player presses Left
        if ((Input.GetKey(KeyCode.A) && keyPressed == false && HUD.playerFuel > 0)
            || (Input.GetKey(KeyCode.LeftArrow) && keyPressed == false && HUD.playerFuel > 0))
        {
            keyPressed = true;
            rb.AddForce(-transform.right * thrust);

            leftLight.GetComponent<Light>().enabled = true;

            rightRocket.GetComponent<Light>().enabled = true;

            FuelFunction();
        }

        if (Input.GetKeyUp(KeyCode.A)
            || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            leftLight.GetComponent<Light>().enabled = false;

            rightRocket.GetComponent<Light>().enabled = false;
        }

        // Player presses Right
        if ((Input.GetKey(KeyCode.D) && keyPressed == false && HUD.playerFuel > 0)
            || (Input.GetKey(KeyCode.RightArrow) && keyPressed == false && HUD.playerFuel > 0))
        {
            keyPressed = true;
            rb.AddForce(transform.right * thrust);

            rightLight.GetComponent<Light>().enabled = true;

            leftRocket.GetComponent<Light>().enabled = true;

            FuelFunction();
        }

        if (Input.GetKeyUp(KeyCode.D)
            || Input.GetKeyUp(KeyCode.RightArrow))
        {
            rightLight.GetComponent<Light>().enabled = false;

            leftRocket.GetComponent<Light>().enabled = false;
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
    }

    void FuelFunction()
    {
        HUD.playerFuel = HUD.playerFuel - (moveCost * Time.deltaTime);

        // This part is being done in HUD script
        /*if (HUD.playerFuel <= 0)
        {
            HUD.playerFuel = 0;
        }*/
    }
}
