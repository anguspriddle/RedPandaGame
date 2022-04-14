using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public float speed = 1.0f;
    public float bounceSpeed = 1.0f;
    public Vector3 applePos;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    public int Score = 0;
    private GameManager gameManager;
    // Position Storage Variables
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
        transform.Rotate(0, speed, 0);
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
            
        transform.position = tempPos;

    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.UpdateScore(1);
    }
}
