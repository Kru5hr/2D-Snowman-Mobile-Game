using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    public float maxHealth = 100f;
    public float minHealth = 0f;
    public static float health;
    public GameObject GameOverMenu;
    public GameObject PauseButton;
    public GameObject HUD;

    // Use this for initialization
    public void Start ()
    {
        GameOverMenu.SetActive(false);
        healthBar = GetComponent<Image>();
        health = maxHealth;
        Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	public void Update ()
    {
        healthBar.fillAmount = health / maxHealth;

        if (health >= maxHealth)
        {
            health = maxHealth;
        }

        if (health <= minHealth)
        {
            GameOverMenu.SetActive(true);
            PauseButton.SetActive(false);
            HUD.SetActive(false);
            Time.timeScale = 0f;
        }
	}
}
