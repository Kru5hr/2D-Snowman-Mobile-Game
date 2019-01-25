using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScore : MonoBehaviour
{
    private Text text;
    public static int scoreAmount;

	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        scoreAmount = 0;
	}
	
	// Update is called once per frame
	public void Update ()
    {
        text.text = scoreAmount.ToString();

        if (textScore.scoreAmount == 5)
        {
            snowflakeManager.spawnRateTime = 0.5f;
        }
	}
}