using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardControls : MonoBehaviour
{
	
	// Update is called once per frame
	void Update ()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right);
    }
}
