using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUp : MonoBehaviour
{
    // One Up Variables
    private float speed = 1.0f;
    private Vector3 applePos;
    private float amplitude = 0.5f;
    private float frequency = 1f;
    public GameManager gameManager;
    // Position Variables
    Vector3 posOffset = new Vector3();
    Vector3 temPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        posOffset = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        // This rotates the apple around the y-axis
        transform.Rotate(0, speed, 0);
        // This makes the apple go up and down over a fixed speed, creating a floating effect
        temPos = posOffset;
        temPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = temPos;

    }

    // This function happens when the power up is collided with something
    // The only thing the power up can collide with is the player, so it will only happen when collision with the player occurs.
    // This function destroys the powerup, and increases the lives the player has left by 1.
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.lives += 1;
    }
}
