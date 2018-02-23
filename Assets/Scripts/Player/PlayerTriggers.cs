using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTriggers : MonoBehaviour
{
    public float fuelAmount;

    // Use this for initialization
    void Start()
    {
        fuelAmount = 20f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Lose");
        }

        if (other.gameObject.CompareTag("Fuel"))
        {
            other.gameObject.SetActive(false);

            HUD.playerFuel = HUD.playerFuel + fuelAmount;
        }
    }
}
