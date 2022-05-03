using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float horizontalInput;
    public bool onGround = true;
    private Rigidbody playerRb;
    private float jumpForce = 10.0f;
    public float speed = 10.0f;
    private float gravityModifier = 1f;
    private float jumpAmount = 0;
    private DoubleJump Double Jump;
    
  
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpAmount < 2) // This adds jump button, puts it on space
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpAmount += 1;
            onGround = false;
        }
     
    
     
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    
        playerRb.angularVelocity = Vector3.zero;
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        jumpAmount = 0;
        onGround = true;
        if (Collision.gameObject.tag == "Double Jump")
        {
            jumpAmount = jumpAmount + 1;
        }
    }
}
