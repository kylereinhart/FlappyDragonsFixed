using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
        Score.mscoreValue = 0f;
    }

    public void MenuScreen()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public static void Options()
    {
        //SceneManager.LoadScene()
    }
}
