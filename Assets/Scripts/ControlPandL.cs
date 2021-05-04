using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPandL : MonoBehaviour
{
    public Text points;
    public Text lives;
    public static int numPoints = 0;

    void Start()
    {
        points.text = numPoints.ToString();
        lives.text = IntroSceneVariables.numLives.ToString();
    }
    public void increasePoints()
    {
        numPoints += 1;
        points.text = numPoints.ToString();
    }

    public void decreasePoints()
    {
        numPoints -= 1;
        points.text = numPoints.ToString();
    }

    public void increaseLives()
    {
        IntroSceneVariables.numLives += 1;
        lives.text = IntroSceneVariables.numLives.ToString();
    }

    public void decreaseLives()
    {
        IntroSceneVariables.numLives -= 1;
        lives.text = IntroSceneVariables.numLives.ToString();
    }
}
