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

    /// <summary>
    /// When you pause the game using TimeScale, update will 
    /// continue to get called, but FixedUpdate won't. 
    /// This will freeze all physics-based movement, and I believe
    /// you cannot measure time in Pause state (using Time.time).
    /// 
    /// Time.realtimeSinceStartup and Time.unscaledTime are not 
    /// affected by time scale and will continue to measure time 
    /// even when the game is paused.
    /// </summary>
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
