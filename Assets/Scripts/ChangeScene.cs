using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void gameScene()
    {
        SceneManager.LoadScene(1);
        Debug.Log("load game");
    }

    public void endScreen()
    {
        SceneManager.LoadScene(2);
        Debug.Log("load credits");
    }
    public void introScreen()
    {
        SceneManager.LoadScene(0);
        Debug.Log("load intro");
    }
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game exited");
    }
}
