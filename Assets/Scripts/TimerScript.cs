using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public Text timeIndicator;
    float timeLeft = IntroSceneVariables.timeToPlay;
    void Start()
    {
        timeIndicator.text = timeLeft.ToString();
    }

    

    void Update()
    {
        timeIndicator.text = Mathf.Round(timeLeft).ToString();
        timeLeft -= Time.deltaTime;

         if(timeLeft < 0)
         {
             SceneManager.LoadScene(2);
             Debug.Log("OUT OF TIME");
         }
    }
}
