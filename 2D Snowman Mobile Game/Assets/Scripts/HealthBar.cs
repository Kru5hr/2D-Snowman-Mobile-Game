using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    float maxHealth = 100f;
    public static float health;
    public GameObject GameOverMenu;
    public GameObject PauseButton;
    public GameObject HUD;
    
    // Use this for initialization
	void Start ()
    {
        GameOverMenu.SetActive(false);
        healthBar = GetComponent<Image>();
        health = maxHealth;
        Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        healthBar.fillAmount = health / maxHealth;

        if (HealthBar.health > 100)
        {
            HealthBar.health = 100;
        }

        if (HealthBar.health == 0)
        {
            GameOverMenu.SetActive(true);
            PauseButton.SetActive(false);
            HUD.SetActive(false);
            Time.timeScale = 0f;
            AudioListener.volume = 0.045f;
        }
	}
}
