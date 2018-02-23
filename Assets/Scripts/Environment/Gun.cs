using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;
    public float bulletSpeed;

    // Use this for initialization
    void Start()
    {
        bulletSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject clone = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);

        clone.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
    }
}
