using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Camera Variables
    public GameObject player; // Calls game object of player to variable
    public Vector3 offset;
    public bool follow = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This if statement happens when the camera is allowed to follow the player
        // It will constantly follow the player with a small offset to get a good view of the game.
        // This statement will only stop when the gameover state is called, or the player issues a dying state.     
        if (follow == true) 
        {
            // This sets the position of the camera to be the same position of the player, with a Y and Z value offset to make the game visible.
            transform.position = player.transform.position + new Vector3(0, 2, -40);
        }

    }
}
