using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowflakeManager : MonoBehaviour
{
    public GameObject snowflake; //The snowlfake prefab to be spawned
    float randX;
    Vector2 spawnPos;
    public static float spawnRateTime = 1.25f; //How long before each spawn
    public float nextSpawn = 0f;

    public void Update()
    {
        snowflake.transform.localScale = transform.root.localScale;

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRateTime;
            randX = Random.Range(-2f, 2f);
            spawnPos = new Vector2(randX, transform.position.y);
            Instantiate(snowflake, spawnPos, Quaternion.identity); 
        }
    }
}