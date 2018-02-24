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

    public GameObject shotLight;
    public float lightRate;

    // Use this for initialization
    void Start()
    {
        bulletSpeed = -100;

        fireRate = Random.Range(1f, 3f);

        lightRate = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasFired == false)
        {
            StartCoroutine(FireShot());
        }
    }

    void Shoot()
    {
        GameObject clone = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);

        clone.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed);
    }

    IEnumerator FireShot()
    {
        hasFired = true;

        StartCoroutine(FireLight());

        Shoot();

        yield return new WaitForSeconds(fireRate);

        hasFired = false;
    }

    IEnumerator FireLight()
    {
        shotLight.SetActive(true);

        yield return new WaitForSeconds(lightRate);

        shotLight.SetActive(false);
    }
}
