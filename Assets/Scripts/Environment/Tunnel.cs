using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
    public GameObject[] vertObArray, horzObArray;
    private int randomVertOb, randomHorzOb;

    public GameObject[] tunnelLight;
    private int randomLightInt;

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
        }
    }

    void RandomLight()
    {
        randomLightInt = Random.Range(0,4);

        tunnelLight[randomLightInt].SetActive(true);
    }
}
