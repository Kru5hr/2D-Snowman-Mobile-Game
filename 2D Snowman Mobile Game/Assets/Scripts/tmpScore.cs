using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tmpScore : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text lastScore;
    public TMP_Text hscore;
    public static int scoreAmount;

	// Use this for initialization
	void Start ()
    {
        score = GetComponent<TMP_Text>();
        scoreAmount = 0;
        hscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
	}
	
	// Update is called once per frame
	public void Update ()
    {
        score.text = scoreAmount.ToString();
        lastScore.text = scoreAmount.ToString();

        if (scoreAmount > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", scoreAmount);
            hscore.text = scoreAmount.ToString();
        }


        
        //if (tmpScore.scoreAmount == 5)
        //{
            //snowflakeManager.spawnRateTime = 0.5f;
        //}
	}
}