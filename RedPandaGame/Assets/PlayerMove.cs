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
    private float gravityModifier = 1.5f;
    public float jumpAmount = 0;
    public GameManager gameManager;

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
     
        if (transform.position.y <= -30)
        {
            Destroy(gameObject);
            Debug.Log("Dead");
        }
     
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    
        playerRb.angularVelocity = Vector3.zero;
       
    }
    private void OnCollisionEnter(Collision col)
    {
        jumpAmount = 0;
        onGround = true;
    }
}
