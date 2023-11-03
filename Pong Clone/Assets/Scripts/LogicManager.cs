using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text AIScore;
    public Text PlayerScore;
    public Text GameOverText;
    public int winningScore = 11;

    void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(AIScore.text) >= winningScore || int.Parse(PlayerScore.text) >= winningScore)
        {
            gameOverPanel.SetActive(true); // Show the game over panel
            Time.timeScale = 0; // Pause the game
            if(int.Parse(AIScore.text) >= winningScore)
            {
                GameOverText.text = "Computer Wins !!! \n Play Again ? \n";
            }
            else if (int.Parse(PlayerScore.text) >= winningScore)
            {
                GameOverText.text = "You Win !!! \n Play Again ? \n";
            }
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
