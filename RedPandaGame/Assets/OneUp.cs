using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUp : MonoBehaviour
{
    private float speed = 1.0f;
    private Vector3 applePos;
    private float amplitude = 0.5f;
    private float frequency = 1f;
    public GameManager gameManager;
    // Position Storage Variables
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
        transform.Rotate(0, speed, 0);
        temPos = posOffset;
        temPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = temPos;

    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.lives += 1;
    }
}
