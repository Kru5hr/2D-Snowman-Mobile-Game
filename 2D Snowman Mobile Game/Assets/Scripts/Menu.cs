using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public class LoadOnClick : MonoBehaviour
    {

        public GameObject loadingImage;

        public void LoadScene(int level)
        {
            loadingImage.SetActive(true);
            Application.LoadLevel(level);
        }
    }
}
