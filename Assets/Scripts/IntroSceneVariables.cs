using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroSceneVariables : MonoBehaviour
{
    
    public Dropdown playerLives;
    public static int numLives = 1;
    public void selectLives()
    {
        switch (playerLives.value)
        {
            case 0:
            numLives = 1;
            Debug.Log(numLives);
            break;
            case 1:
            numLives = 1;
            Debug.Log(numLives);
            break;
            case 2:
            numLives = 2;
            Debug.Log(numLives);
            break;
            case 3:
            numLives = 3;
            Debug.Log(numLives);
            break;
            case 4:
            numLives = 4;
            Debug.Log(numLives);
            break;
            case 5:
            numLives = 5;
            Debug.Log(numLives);
            break;
            case 6:
            numLives = 6;
            Debug.Log(numLives);
            break;
            case 7:
            numLives = 7;
            Debug.Log(numLives);
            break;
            case 8:
            numLives = 8;
            Debug.Log(numLives);
            break;
            case 9:
            numLives = 9;
            Debug.Log(numLives);
            break;
            default:
            numLives = 25;
            Debug.Log(numLives);
            break;
        }
    }

    public InputField nameInput;
    public static string playerName = "Player";

    public void setPlayerName()
    {
        playerName = nameInput.text.ToString();
        Debug.Log(playerName);
    }
    public Slider timeSlider;
    static public float timeToPlay = 60;
    public Text timeIndicator;

    public void setTheTime()
    {

        timeToPlay = timeSlider.value;
        timeIndicator.text = timeToPlay.ToString();
    
    }

}
