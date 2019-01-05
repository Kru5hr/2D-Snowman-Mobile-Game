using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.name)
        {
            case "snowflake":
                Score.scoreAmount += 1;
                Destroy(collision.gameObject);
                break;
        }
    }

}
