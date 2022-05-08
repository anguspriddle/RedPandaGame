using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    // Variables
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
        // This checks if the waypoint B has been reached by the platform
        if (waypointReached == false)
        {   
            // If the waypoint has not been reached, it will move towards the waypoint B at a set speed
            transform.position = Vector3.MoveTowards(transform.position, waypointB.position, speed * Time.deltaTime);
            if (transform.position == waypointB.position)
            {
                // If the waypoint is reached, it will set it to true.
                waypointReached = true;
            }
        }
        // This checks/occurs if the waypoint B has been reached, and the platform now must go down to waypoint A.
        else if (waypointReached == true)
        {
            // If waypoint B has been reached, it will move the platform towards waypoint A.
            transform.position = Vector3.MoveTowards(transform.position, waypointA.position, speed * Time.deltaTime);
            if (transform.position == waypointA.position)
            {
                // This makes the platform go back to waypoint B again upon reaching waypoint A, making an infinite loop.
                waypointReached = false;
            }
        }
    }
}
