using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snowflakeScore : MonoBehaviour
{
    public void OnParticleCollision(GameObject col)
    {

        if (col.gameObject.name == "ground")
        {
            HealthBar.health -= 10f;
            //Destroy(gameObject);
        }
        else if (col.gameObject.name == "player_snowman")
        {
            tmpScore.scoreAmount += 1;
            HealthBar.health += 10f;
            //Destroy(gameObject);
        }
    }
}
