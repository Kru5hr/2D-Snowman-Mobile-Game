using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToStart : MonoBehaviour
{
    public GameObject Panel;
    
    // Use this for initialization
	void Start ()
    {
        Time.timeScale = 0;
        Panel.SetActive(true);
	}
	
	// Update is called once per frame
	public void StartGame ()
    {
            Time.timeScale = 1;
    }
}
