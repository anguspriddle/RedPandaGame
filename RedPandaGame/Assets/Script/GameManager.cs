using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Game Manager Variables
    public float time = 240.0f;
    public TextMeshProUGUI timerText; // This calls in text to be assigned to a variable.
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI instructionsText;
    public GameObject restartButton;
    public GameObject scoreLivesBackdrop;
    public GameObject timeBackdrop;
    public int lives = 3;
    public TextMeshProUGUI livesText;
    // Start is called before the first frame update
    void Start()
    {
        // Sets the ABSOLUTE starting score to 0, no matter what.
        score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        // This decreases the time left.
        time -= Time.deltaTime;
        // This all displays variables Time, Score, Lives.
        timerText.text = "Time: " + time;
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }

    // This function will occur when a game over state is needed,
    public void GameOver()
    {
        // It will display the game over text, and remove all the other text form visibility
        gameOverText.text = "Game Over! You scored: " + score;
        gameOverText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        livesText.gameObject.SetActive(false);
        // This will display the restart button
        restartButton.gameObject.SetActive(true);   
    }
    // This function will restart the game upon button press.
    public void RestartGame()
    {
        // This calls for the scene to be reloaded.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
