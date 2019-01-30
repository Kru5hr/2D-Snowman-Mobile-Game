using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public TMP_Text tmpTimer;

	// Use this for initialization
	void Start ()
    {
        tmpTimer.text = timeStart.ToString("F1");
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeStart += Time.deltaTime;
        tmpTimer.text = timeStart.ToString("F1");
    }
}
