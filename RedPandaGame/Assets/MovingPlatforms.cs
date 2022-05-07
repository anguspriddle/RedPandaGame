using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public Transform waypointA, waypointB;
    private float speed = 5.0f;
    private bool waypointReached;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (waypointReached == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypointB.position, speed * Time.deltaTime);
            if (transform.position == waypointB.position)
            {
                waypointReached = true;
            }
        }
        else if (waypointReached == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypointA.position, speed * Time.deltaTime);
            if (transform.position == waypointA.position)
            {
                waypointReached = false;
            }
        }
    }
}
