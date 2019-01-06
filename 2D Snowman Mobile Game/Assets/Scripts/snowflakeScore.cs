using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snowflakeScore : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "ground")
        {
            HealthBar.health -= 10f;
            Destroy(gameObject);
        }
        else if (col.gameObject.name == "player_snowman")
        {
            textScore.scoreAmount += 1;
            Destroy(gameObject);
        }
    }
}
