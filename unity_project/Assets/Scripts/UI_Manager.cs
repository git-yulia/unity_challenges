using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    private bool gameIsPaused; 

    void Start()
    {
        gameIsPaused = false; 
    }

    public void ToggleGamePause()
    {
        if (!gameIsPaused)
        {
            Time.timeScale = 0;
            gameIsPaused = true; 
        }
        else
        {
            Time.timeScale = 1;
            gameIsPaused = false;
        }
    }
}
