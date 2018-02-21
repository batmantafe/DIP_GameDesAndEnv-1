using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
    public GameObject[] obstaclesArray;
    private int randomOb1, randomOb2, randomOb3, randomOb4;

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
            randomOb1 = Random.Range(0, 9);
            randomOb2 = Random.Range(0, 9);
            randomOb3 = Random.Range(0, 9);
            randomOb4 = Random.Range(0, 9);

            obstaclesArray[randomOb1].SetActive(true);
            obstaclesArray[randomOb2].SetActive(true);
            obstaclesArray[randomOb3].SetActive(true);
            obstaclesArray[randomOb4].SetActive(true);
        }
    }
}
