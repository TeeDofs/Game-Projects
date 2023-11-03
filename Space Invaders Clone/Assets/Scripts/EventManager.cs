using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    public GameObject victoryPanel;
    private int totalEnemies;

    private void Start()
    {
        victoryPanel.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        ActivateVictoryPanel();
    }

    private void ActivateVictoryPanel()
    {
        if (totalEnemies <= 0)
        {
            Time.timeScale = 0;
            victoryPanel.SetActive(true);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        victoryPanel.SetActive(false);
    }
}
