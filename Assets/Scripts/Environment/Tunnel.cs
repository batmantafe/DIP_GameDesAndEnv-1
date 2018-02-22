using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
    public GameObject[] obstaclesArray;
    private int randomOb1, randomOb2, randomOb3,
                randomOb4, randomOb5, randomOb6,
                randomOb7, randomOb8, randomOb9;

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
            randomOb1 = Random.Range(0, 27);
            randomOb2 = Random.Range(0, 27);
            randomOb3 = Random.Range(0, 27);
            randomOb4 = Random.Range(0, 27);
            randomOb5 = Random.Range(0, 27);
            randomOb6 = Random.Range(0, 27);
            randomOb7 = Random.Range(0, 27);
            randomOb8 = Random.Range(0, 27);
            randomOb9 = Random.Range(0, 27);

            obstaclesArray[randomOb1].SetActive(true);
            obstaclesArray[randomOb2].SetActive(true);
            obstaclesArray[randomOb3].SetActive(true);
            obstaclesArray[randomOb4].SetActive(true);
            obstaclesArray[randomOb5].SetActive(true);
            obstaclesArray[randomOb6].SetActive(true);
            obstaclesArray[randomOb7].SetActive(true);
            //obstaclesArray[randomOb8].SetActive(true);
            //obstaclesArray[randomOb9].SetActive(true);
        }
    }
}
