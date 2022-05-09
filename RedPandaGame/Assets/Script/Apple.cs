using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // Apple Variables
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
        // Rotates object around y axis, constantly.
        transform.Rotate(0, speed, 0);
        // Makes apple go up and down at set speed using Mathf.Sin
        temPos = posOffset;
        temPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
            
        transform.position = temPos;

    }

    // This function happens when the power up is collided with the player.
    // This will increase the player's score by 1 upon collision with player.
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.score += 1;
        Destroy(gameObject);
    }
}
