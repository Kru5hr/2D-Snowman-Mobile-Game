using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class snowflakeScore : MonoBehaviour
{
    public int damageToGive;
    public Transform hitPoint;
    public GameObject hText;
    AudioSource soundAudio;
    public AudioClip ting;
    public AudioClip sball_impact;
    ParticleSystem pSystem;
    public float emValue1 = 0.5f;
    public float emValue2 = 5f;
    public float emValue3 = 10f;
    public float emValue4 = 15f;
    public float emValue5 = 20f;

    public void Start()
    {
        soundAudio = GetComponent<AudioSource>();
        pSystem = GetComponent<ParticleSystem>();

        var em = pSystem.emission;

        em.rateOverTime = emValue1;
    }

    public void OnParticleCollision(GameObject col)
    {

        if (col.gameObject.name == "ground")
        {
            HealthBar.health -= 10f;
            soundAudio.clip = sball_impact;
            soundAudio.Play();
            var clone = (GameObject)Instantiate(hText, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<HBarIndicator>().damageNumber = damageToGive;
        }
        else if (col.gameObject.name == "player_snowman")
        {
            tmpScore.scoreAmount += 1;
            HealthBar.health += 10f;
            soundAudio.clip = ting;
            soundAudio.Play();
        }
    }

    void Update()
    {
        var em = pSystem.emission;

        if (tmpScore.scoreAmount == 3)
        {
            em.rateOverTime = emValue2;
        }

        if (tmpScore.scoreAmount == 10)
        {
            em.rateOverTime = emValue3;
        }

        if (tmpScore.scoreAmount == 15)
        {
            em.rateOverTime = emValue4;
        }

        if (tmpScore.scoreAmount == 20)
        {
            em.rateOverTime = emValue5;
        }
    }
}
