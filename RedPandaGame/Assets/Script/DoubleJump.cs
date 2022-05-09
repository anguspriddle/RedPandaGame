using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    // Double Jump Variables
    public Player player;
    public GameObject powerup;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Function occurs on collision with player (player is the only thing that can possibly collide with the double jump powerup)
    // Will set the player's variable of allowing triple jump to true
    // Destroys powerup on collision, making it one time use. 
    void OnTriggerEnter(Collider other)
    {
        player.TripleJump = true;
        Destroy(gameObject);
    }

}
