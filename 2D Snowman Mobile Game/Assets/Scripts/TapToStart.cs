using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToStart : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Time.timeScale = 1;
        }
        
    }
}
