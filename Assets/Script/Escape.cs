using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    // 다른 스크립트에서 쉽게 접근이 가능하도록 static
    public static bool GameIsPaused = false;
    public GameObject EscapeCanvas;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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

    public void Resume()
    {
        EscapeCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        EscapeCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ToSettingMenu()
    {
        Debug.Log("아직 미구현입니다...");
    }

    public void ToMain()
    {
        SceneManager.LoadScene("MainScene");
        //Time.timeScale = 1f;
        //SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("아직 미구현입니다...");
        Application.Quit();
    }
}
