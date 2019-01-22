using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMoveSwipe : MonoBehaviour {

    private Vector2 startTouchPosition, endTouchPosition;
    private Vector3 startRocketPosition, endRocketPosition;
    private float flyTime;
    private float flightDuration = 0.1f;

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) //once touch input started
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -1.5f)
                StartCoroutine(Fly("left"));

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < 1.5f)
                StartCoroutine(Fly("right"));
        }
    }

    private IEnumerator Fly(string whereToFly)
    {
        switch (whereToFly)
        {
            case "left":
                flyTime = 0f;
                startRocketPosition = transform.position;
                endRocketPosition = new Vector3
                    (startRocketPosition.x - 1.5f, transform.position.y, transform.position.z);

                while (flyTime < flightDuration)
                {
                    flyTime += Time.deltaTime;
                    transform.position = Vector2.Lerp
                        (startRocketPosition, endRocketPosition, flyTime / flightDuration);
                    yield return null;
                }
                break;

            case "right":
                flyTime = 0f;
                startRocketPosition = transform.position;
                endRocketPosition = new Vector3
                    (startRocketPosition.x + 1.5f, transform.position.y, transform.position.z);

                while (flyTime < flightDuration)
                {
                    flyTime += Time.deltaTime;
                    transform.position = Vector2.Lerp
                        (startRocketPosition, endRocketPosition, flyTime / flightDuration);
                    yield return null;
                }
                break;
        }

    }
}
