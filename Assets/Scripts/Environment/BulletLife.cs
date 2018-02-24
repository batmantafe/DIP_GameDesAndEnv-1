using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    public GameObject laser, laserHit;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        laser.SetActive(false);
        laserHit.SetActive(true);

        if (laserHit.activeSelf == true)
        {
            Destroy(gameObject);
        }
    }
}
