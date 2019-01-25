using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tmpScore : MonoBehaviour
{
    private TMP_Text tmp;
    public static int scoreAmount;

	// Use this for initialization
	void Start ()
    {
        tmp = GetComponent<TMP_Text>();
        scoreAmount = 0;
	}
	
	// Update is called once per frame
	public void Update ()
    {
        tmp.text = scoreAmount.ToString();

        if (textScore.scoreAmount == 5)
        {
            snowflakeManager.spawnRateTime = 0.5f;
        }
	}
}