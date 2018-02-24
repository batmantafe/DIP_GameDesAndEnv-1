using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public Transform nav1, nav2;
    public float speed;

    private bool obAtNav1;

    // Use this for initialization
    void Start()
    {
        obAtNav1 = false;

        speed = Random.Range(3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        ObMovement();
    }

    void ObMovement()
    {
        float step = speed * Time.deltaTime;

        if (obAtNav1 == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, nav2.position, step);

            if (transform.position == nav2.position)
            {
                obAtNav1 = false;
            }
        }

        if (obAtNav1 == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, nav1.position, step);

            if (transform.position == nav1.position)
            {
                obAtNav1 = true;
            }
        }
    }
}
