using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Player player1;
    public Vector3 offset;
    public bool follow = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (follow == true) 
        {
            transform.position = player.transform.position + new Vector3(0, 2, -40);
        }
        

    }
}
