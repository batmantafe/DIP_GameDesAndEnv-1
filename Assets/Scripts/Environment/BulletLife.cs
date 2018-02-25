using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    public GameObject bullet, bulletExplosion;
    public float explosionTime;
    
    // Use this for initialization
    void Start()
    {
        explosionTime = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        StartCoroutine(LaserHit());
    }

    IEnumerator LaserHit()
    {
        bulletExplosion.SetActive(true);
        bullet.SetActive(false);

        yield return new WaitForSeconds(explosionTime);

        Destroy(gameObject);
    }
}
