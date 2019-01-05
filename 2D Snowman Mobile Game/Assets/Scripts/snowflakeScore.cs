using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowflakeScore : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "ground")
        {
            HealthBar.health -= 10f;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
