using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Controls : MonoBehaviour
{
    Vector2 startPos, endPos, direction; //touch start position, touch end position, swipe direction
    float touchTimeStart, touchTimeFinish, timeInterval; //calculate swipe time

    public float jumpForce;
    public bool jumpAllowed = false;
    public bool isGrounded;
    public Rigidbody2D rb;
    AudioSource soundAudio;
    public AudioClip jump;
    public AudioClip slide;

    [Range(0.05f, 1f)]               //slide for inspector window
    public float throwForce = 0.03f; //to control force throw

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        soundAudio = GetComponent<AudioSource>();
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

            rb.AddForce(-direction / timeInterval * throwForce);

            if (endPos.y > startPos.y && rb.velocity.y == 0)
            {
                jumpAllowed = true;
            }
        }

        //********KEYBOARD CONTROLS****************

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left);
            soundAudio.clip = slide;
            soundAudio.Play();
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right);
            soundAudio.clip = slide;
            soundAudio.Play();
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            jumpAllowed = true;
        }

    }

    void JumpIfAllowed()
    {
        if (jumpAllowed)
        {
            rb.AddForce(Vector2.up * jumpForce);
            jumpAllowed = false;
            isGrounded = false;
            soundAudio.clip = jump;
            soundAudio.Play();
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
