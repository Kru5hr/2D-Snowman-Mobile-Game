using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour
{
    public void loadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
