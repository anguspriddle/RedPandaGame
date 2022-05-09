using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePointApple : MonoBehaviour
{
    // Three Point Apple Variables
    public float speed = 1.0f;
    public float bounceSpeed = 1.0f;
    public Vector3 applePos;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    public int Score = 0;
    public GameManager gameManager;
    // Position Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

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
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;

    }

    // This function happens when the power up is collided with the player.
    // This will increase the player's score by 3 upon collision with player.
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.score += 3;
        Destroy(gameObject);
    }
}
