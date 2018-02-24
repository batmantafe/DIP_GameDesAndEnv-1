using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;
    public float bulletSpeed;

    public float fireRate;
    private bool hasFired = false;

    // Use this for initialization
    void Start()
    {
        bulletSpeed = -100;

        fireRate = Random.Range(2.5f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // For Testing
        /*if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }*/

        if (hasFired == false)
        {
            StartCoroutine(FireShot());
        }
    }

    void Shoot()
    {
        GameObject clone = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);

        clone.GetComponent<Rigidbody>().velocity = new Vector3(0,0,bulletSpeed);
    }

    IEnumerator FireShot()
    {
        hasFired = true;

        Shoot();

        yield return new WaitForSeconds(fireRate);

        hasFired = false;
    }
}
