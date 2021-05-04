using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class Pause : MonoBehaviour
{
 
    public GameObject menu1;
    private bool isPaused = false;

    void Start()
    {
        menu1.SetActive(false);
        Time.timeScale = 1;
    }
    public void pause()
    {
        menu1.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0;
        isPaused = true;
    }
    public void Unpause()
    {
        menu1.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        isPaused = false;
    }
    public bool IsGamePaused()
    {
        return isPaused;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                Unpause();
            }
            else
            {
                pause();
            }
        }
    }

    public void restartGame()
    {
        IntroSceneVariables.numLives = 0;
        ControlPandL.numPoints = 0;
        SceneManager.LoadScene(1);
    
    }
}
