using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenController : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("FlapGameScene");
    }
}
