using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float time = 240.0f;
    public TextMeshProUGUI timerText;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
      
    }


    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = "Time: " + time;
        scoreText.text = "Score: " + score;
    }


}
