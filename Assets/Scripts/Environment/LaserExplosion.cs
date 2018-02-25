using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserExplosion : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(LaserHitTarget());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LaserHitTarget()
    {
        // Nothing here.

        yield return new WaitForSeconds(0.05f);

        Destroy(gameObject);
    }
}
