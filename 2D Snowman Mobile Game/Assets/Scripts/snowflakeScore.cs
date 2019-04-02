using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SnowflakeScore : MonoBehaviour
{
    public int damageToGive;
    public Transform hitPoint;
    public GameObject hText;
    AudioSource soundAudio;
    public AudioClip ting;
    public AudioClip sball_impact;
    ParticleSystem pSystem;
    public float emValue1 = 0.5f;
    public float emValue2 = 0.75f;
    public float emValue3 = 1.25f;
    public float emValue4 = 2f;
    public float emValue5 = 3f;

    public float spValue1 = 1f;
    public float spValue2 = 1.5f;
    public float spValue3 = 2f;
    public float spValue4 = 2.5f;
    public float spValue5 = 3f;

    public void Start()
    {
        soundAudio = GetComponent<AudioSource>();
        pSystem = GetComponent<ParticleSystem>();

        var em = pSystem.emission;
        var sp = pSystem.velocityOverLifetime;

        em.rateOverTime = emValue1;
        sp.speedModifier = spValue1;
    }

    public void OnParticleCollision(GameObject col)
    {

        if (col.gameObject.tag == "Ground")
        {
            HealthBar.health -= 10f;
            Debug.Log(HealthBar.health);
            soundAudio.clip = sball_impact;
            soundAudio.Play();
            var clone = (GameObject)Instantiate(hText, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<HBarIndicator>().damageNumber = damageToGive;
        }
        else if (col.gameObject.tag == "Player")
        {
            TmpScore.scoreAmount += 1;
            HealthBar.health += 5f;
            Debug.Log(HealthBar.health);
            soundAudio.clip = ting;
            soundAudio.Play();
        }
    }

    public void Update()
    {
        var em = pSystem.emission;
        var sp = pSystem.velocityOverLifetime;

        if (TmpScore.scoreAmount == 5)
        {
            em.rateOverTime = emValue2;
            sp.speedModifier = spValue2;
        }

        if (TmpScore.scoreAmount == 10)
        {
            em.rateOverTime = emValue3;
            sp.speedModifier = spValue3;
        }

        if (TmpScore.scoreAmount == 25)
        {
            em.rateOverTime = emValue4;
            sp.speedModifier = spValue4;
        }

        if (TmpScore.scoreAmount == 50)
        {
            em.rateOverTime = emValue5;
            sp.speedModifier = spValue5;
        }
    }
}
