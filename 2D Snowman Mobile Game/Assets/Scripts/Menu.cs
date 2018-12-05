using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
	private void onLevelSelect(int currentIndex)
    {
        SceneManager.LoadScene("Lvl_Selector");
        Debug.Log("Selecting level : " + currentIndex);
    }
}
