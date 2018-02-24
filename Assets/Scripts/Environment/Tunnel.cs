using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
    public GameObject[] vertObArray, horzObArray;
    private int randomVertOb, randomHorzOb;

    public GameObject[] tunnelLight;
    public GameObject[] tunnelLightB;
    private int randomLightInt;
    private int randomLightBInt;

    private int randomVertMove, randomHorzMove;

    public GameObject[] fuelArray;
    private int giveFuel, randomFuelInt;

    public Material transpMat;

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

            if (randomVertOb == 1)
            {
                vertObArray[randomVertOb].GetComponent<Renderer>().material = transpMat;
            }

            if (randomHorzOb == 1)
            {
                horzObArray[randomHorzOb].GetComponent<Renderer>().material = transpMat;
            }
        }
    }

    void RandomLight()
    {
        randomLightInt = Random.Range(0,4);
        randomLightBInt = Random.Range(0,4);

        tunnelLight[randomLightInt].SetActive(true);
        tunnelLightB[randomLightBInt].SetActive(true);
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

                vertObArray[randomVertOb].GetComponent<Renderer>().material = transpMat;
            }
        }

        if (randomHorzMove == 1)
        {
            horzObArray[randomHorzOb].GetComponent<ObstacleMove>().enabled = true;

            horzObArray[randomHorzOb].GetComponent<Renderer>().material = transpMat;
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
