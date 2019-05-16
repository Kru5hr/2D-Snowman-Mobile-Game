using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Controls_dup : MonoBehaviour
{
    Vector2 startPos, endPos, direction; //touch start position, touch end position, swipe direction
    float touchTimeStart, touchTimeFinish, timeInterval; //calculate swipe time
    public float jumpForce;
    public bool jumpAllowed = false;
    public bool isGrounded;
    public Rigidbody2D rb;
    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
    [Range(0.05f, 1f)]               //slide for inspector window
    public float throwForce = 0.03f; //to control force throw
    public GameObject smokePuff;
    private Touch touch;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        JumpIfAllowed();
    }
    // Update is called once per frame
    void Update()
    {
        //*************TOUCH CONTROLS*********************
        //SLIDE
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    touchTimeStart = Time.time;
                    startPos = Input.GetTouch(0).position;
                    break;

                case TouchPhase.Ended:

                    touchTimeFinish = Time.time;
                    timeInterval = touchTimeFinish - touchTimeStart;
                    endPos = Input.GetTouch(0).position;
                    direction = startPos - endPos;
                    rb.AddForce(-direction / timeInterval * throwForce);

                    if (isGrounded == true)
            {
                        jumpAllowed = true;
                    }

                    break;
            }
        }

        if (Input.touchCount == 1 && startPos == endPos && isGrounded == true)
        {
            jumpAllowed = true;
        }

        //********KEYBOARD CONTROLS****************

        if (Input.GetKeyDown(KeyCode.A))
        {
            source2.Play();
            Instantiate(smokePuff, transform.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left);
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            source3.Play();
            Instantiate(smokePuff, transform.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            jumpAllowed = true;
        }

        JumpIfAllowed();

    }

    void JumpIfAllowed()
    {
        if (jumpAllowed)
        {
            rb.AddForce(Vector2.up * jumpForce);
            jumpAllowed = false;
            isGrounded = false;
            source1.Play();
            HealthBar.health -= 10f;
            //Debug.Log(HealthBar.health);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
