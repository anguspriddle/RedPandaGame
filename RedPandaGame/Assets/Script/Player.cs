using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // These are the variables for the player
    public float horizontalInput;
    public bool onGround = true; // This bool will be used to show when the player is touching the ground
    private Rigidbody playerRb; // This sets the rigidbody component to a variable name
    private float jumpForce = 10.0f;
    public float speed = 10.0f; // This is the speed of the player
    private float gravityModifier = 1f;
    public float jumpAmount = 0;
    public GameManager gameManager; // This calls the game manager script in.
    public bool TripleJump;
    public bool dead;
    public FollowPlayer CameraPlayer;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); // This calls the rigid body component on the player
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()   
    {
        // This adds jump button, puts it on space, with a cap of 2 jumps (double jump)
        if (Input.GetKeyDown(KeyCode.Space) && jumpAmount < 2 && TripleJump == false) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpAmount += 1;
            onGround = false;
        }
        // This makes it a triple jump cap when the triple jump power up is touched by the player
        if (Input.GetKeyDown(KeyCode.Space) && jumpAmount < 3 && TripleJump == true) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpAmount += 1;
            onGround = false;
        }
        // This detects if the player is below y -30.
        // If player is below y -30, it calls the game over function from the game manager
        // If then calls the camera follow bool and turns it off so the camera stop following the player
        if (transform.position.y <= -30)
        {
            gameManager.GameOver();
            CameraPlayer.follow = false;
        }
        // This will destroy the player the moment it reaches below y -80.
        if (transform.position.y <= -80)
        {
            Destroy(gameObject);
        }
        // This will do the same as the position y-30 code, but will play when the time runs out.
        if (gameManager.time <= 0)
        {
            gameManager.GameOver();
            Destroy(gameObject);
            CameraPlayer.follow = false;
        }
        // This is the same as the above code, but it will play when the player runs out of lives
        if (gameManager.lives == 0)
        {
            gameManager.GameOver();
            CameraPlayer.follow = false;
            Destroy(gameObject);
        }

        // This calls for the horizontal input (A, D, Left Arrow, Right Arrow)
        // It then translates the player's X position in accordance to the set speed and horizontal input.
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        
        playerRb.angularVelocity = Vector3.zero;
       
    }
    // This function occurs when the player collides with the ground.
    // It sets the amount of jumps made by the player back to zero
    // It set the onGround bool to true
    // It also sets the TripleJump bool to false, to get rid of the powerup.
    private void OnCollisionEnter(Collision col)
    {
        jumpAmount = 0;
        onGround = true;
        TripleJump = false;
    }
}
