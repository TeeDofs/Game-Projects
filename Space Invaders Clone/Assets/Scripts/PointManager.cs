using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PointManager : MonoBehaviour
{
    public int finalScore;
    public TMP_Text scoreText;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;

    void Start()
    {
        scoreText.text = "Score: " + finalScore;
    }

    public void UpdateScore(int points)
    {
        finalScore += points;
        scoreText.text = "Score: " + finalScore;
    }

    public void HighScoreUpdate()
    {
        //Is there already a high score
        if(PlayerPrefs.HasKey("SavedHighScore"))
        {
            //is the new score higher than saved scores
            if(finalScore > PlayerPrefs.GetInt("SavedHighScore"))
            {
                //set a new high score
                PlayerPrefs.SetInt("SavedHighScore", finalScore);
            }
        }
        else
        {
            //set if no high score
            PlayerPrefs.SetInt("SavedHighScore", finalScore);
        }

        //Updating Text
        finalScoreText.text = finalScore.ToString();
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}
