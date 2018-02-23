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

    // Use this for initialization
    void Start()
    {
        RandomObstacles();

        RandomLight();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RandomObstacles()
    {
        if (!gameObject.CompareTag("Start"))
        {
            randomVertOb = Random.Range(0, 3);
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
            vertObArray[randomVertOb].GetComponent<ObstacleMove>().enabled = true;
        }

        if (randomHorzMove == 1)
        {
            horzObArray[randomHorzOb].GetComponent<ObstacleMove>().enabled = true;
        }
    }
}
