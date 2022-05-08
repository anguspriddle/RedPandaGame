using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float time = 300.0f;
    public TextMeshProUGUI timerText;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI instructionsText;
    public GameObject restartButton;
    public int lives = 3;
    public TextMeshProUGUI livesText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = "Time: " + time;
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over! You scored: " + score;
        gameOverText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
        livesText.gameObject.SetActive(false);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
