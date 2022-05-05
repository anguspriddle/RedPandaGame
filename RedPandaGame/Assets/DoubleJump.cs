using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public PlayerMove player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnCollisionrEnter(Collision col)
    {
        player.jumpAmount += 1;
        Destroy(gameObject);
    }

}
