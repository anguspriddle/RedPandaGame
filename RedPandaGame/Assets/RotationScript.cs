using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0)); // This sets the character's starting rotation to facing right. (90 degrees)
    }

    // Update is called once per frame
    void Update()
    {   
        // This will make the character rotate towards the way the input is moving the player
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0)); // i.e this will face the character left when moving left
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0)); // and this will face the character right when moving right
        }
    }
}
