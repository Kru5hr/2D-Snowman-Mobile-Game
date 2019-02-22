using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HScore : MonoBehaviour
{
    public TMP_Text hscore;
    public int reset;

    // Use this for initialization
    public void Start()
    {
        hscore.text = PlayerPrefs.GetInt("Highscore").ToString();
        reset = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        hscore.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("Highscore", reset);
    }
}
