using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScore : MonoBehaviour
{
    Text txt_Score;
    public static int scoreAmount;

	// Use this for initialization
	void Start ()
    {
        txt_Score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        txt_Score.text = "Score: " + scoreAmount;
	}
}
