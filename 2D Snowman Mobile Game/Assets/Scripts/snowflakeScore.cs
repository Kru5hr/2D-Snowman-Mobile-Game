using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snowflakeScore : MonoBehaviour
{
    public int damageToGive;
    public Transform hitPoint;
    public GameObject hText;

    public void OnParticleCollision(GameObject col)
    {

        if (col.gameObject.name == "ground")
        {
            HealthBar.health -= 10f;

            var clone = (GameObject)Instantiate(hText, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<HBarIndicator>().damageNumber = damageToGive;
        }
        else if (col.gameObject.name == "player_snowman")
        {
            tmpScore.scoreAmount += 1;
            HealthBar.health += 10f;
        }
    }
}
