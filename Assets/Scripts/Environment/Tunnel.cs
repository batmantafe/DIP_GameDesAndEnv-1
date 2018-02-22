using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
    public GameObject[] vertObArray, horzObArray;
    private int randomVertOb, randomHorzOb;

    // Use this for initialization
    void Start()
    {
        RandomObstacles();
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
}
