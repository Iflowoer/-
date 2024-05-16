using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public void SceneChange()
    {
        SceneManager.LoadScene("GameScene1");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("RoadScene");
    }

    public void GoExit()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}