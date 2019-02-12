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

    private void Start()
    {
        soundAudio = GetComponent<AudioSource>();
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
}
