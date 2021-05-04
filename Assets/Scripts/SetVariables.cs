using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVariables : MonoBehaviour
{
    public Text nameIndicator;

    void Start()
    {
        nameIndicator.text = "Currently playing: " + IntroSceneVariables.playerName.ToString();
    }
}
