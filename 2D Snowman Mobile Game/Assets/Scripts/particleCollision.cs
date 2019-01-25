using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCollision : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var coll = ps.collision;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
