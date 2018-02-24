using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
    public GameObject[] vertObArray, horzObArray;
    private int randomVertOb, randomHorzOb;

    public GameObject[] tunnelLight;
    private int randomLightInt;

    private int randomVertMove, randomHorzMove;

    public GameObject[] fuelArray;
    private int giveFuel, randomFuelInt;

    // Use this for initialization
    void Start()
    {
        RandomObstacles();

        RandomLight();

        RandomFuel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RandomObstacles()
    {
        if (!gameObject.CompareTag("Start"))
        {
            randomVertOb = Random.Range(0, 7);
            randomHorzOb = Random.Range(0, 3);

            vertObArray[randomVertOb].SetActive(true);
            horzObArray[randomHorzOb].SetActive(true);

            RandomObMovement();
        }
    }

    void RandomLight()
    {
        randomLightInt = Random.Range(0,4);

        tunnelLight[randomLightInt].SetActive(true);
    }

    void RandomObMovement()
    {
        randomVertMove = Random.Range(0,4);
        randomHorzMove = Random.Range(0,4);

        if (randomVertMove == 1)
        {
            if (!vertObArray[randomVertOb].name.Contains("Gun"))
            {
                vertObArray[randomVertOb].GetComponent<ObstacleMove>().enabled = true;
            }
        }

        if (randomHorzMove == 1)
        {
            horzObArray[randomHorzOb].GetComponent<ObstacleMove>().enabled = true;
        }
    }

    void RandomFuel()
    {
        giveFuel = Random.Range(0,4);

        if (giveFuel == 1)
        {
            randomFuelInt = Random.Range(0,9);

            fuelArray[randomFuelInt].SetActive(true);
        }
    }
}
