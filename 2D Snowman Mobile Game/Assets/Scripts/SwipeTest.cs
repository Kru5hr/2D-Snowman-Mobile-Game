using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPostion;
	
	// Update is called once per frame
	private void Update ()
    {
        if (swipeControls.SwipeLeft)
            desiredPostion += Vector3.left;
        if (swipeControls.SwipeRight)
            desiredPostion += Vector3.right;

        player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPostion, 3f * Time.deltaTime);
    }
}
