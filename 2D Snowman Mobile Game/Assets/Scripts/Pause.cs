using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    bool isPaused = false;

    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
            AudioListener.pause = false;
        }
        else
        {
            Time.timeScale = 0f;
            isPaused = true;
            AudioListener.pause = true;
        }
    }
}
