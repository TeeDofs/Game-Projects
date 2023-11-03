using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int payerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject pauseButton;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        payerScore += scoreToAdd;
        scoreText.text = payerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenuScene");
        gameOverScreen.SetActive(false);
    }
}
