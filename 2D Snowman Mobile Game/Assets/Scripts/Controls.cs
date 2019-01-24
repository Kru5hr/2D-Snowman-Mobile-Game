using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    Vector2 startPos, endPos, direction; //touch start position, touch end position, swipe direction
    float touchTimeStart, touchTimeFinish, timeInterval; //calculate swipe time

    public float jumpForce = 500f;
    public bool grounded = true;

    [Range(0.05f, 1f)]               //slide for inspector window
    public float throwForce = 0.03f; //to control force throw
    
	// Update is called once per frame
	void Update ()
    {
        //*************TOUCH CONTROLS*********************

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) //once touch input started
        {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;

            timeInterval = touchTimeFinish - touchTimeStart;

            endPos = Input.GetTouch(0).position;

            direction = startPos - endPos;

            GetComponent<Rigidbody2D>().AddForce(-direction / timeInterval * throwForce);
        }

        if (!grounded && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            grounded = true;
        }

        if (Input.touchCount == 1 && grounded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce);
            grounded = false;
        }

        //********KEYBOARD CONTROLS****************

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right);
        }
            
    }
}
