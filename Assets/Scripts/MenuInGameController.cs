using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInGameController : MonoBehaviour
{
    public CanvasGroup pauseMenu;

    public void StartLevel(String levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            Utility.SetCanvasGroupEnabled(pauseMenu, true);
        }
        else
        {
            Time.timeScale = 1;
            Utility.SetCanvasGroupEnabled(pauseMenu, false);
        }
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
