using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused;

    public GameObject pauseMenuUI;

    private void Start()
    {
        GameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Pause()
    {
        //pauseMenuUI.SetActive(true);
        pauseMenuUI.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        //pauseMenuUI.SetActive(false);
        pauseMenuUI.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
        Resume();
        Score.mscoreValue = 0f;
    }

    public void Options()
    {
        MainMenu.Options();
    }
}
