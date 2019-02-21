using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource m_MyAudioSource;

    bool m_isPaused = false;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    public void m_pause()
    {
        if (m_isPaused)
        {
            m_MyAudioSource.Pause();
            m_isPaused = false;
        }
    }

    public void m_play()
    {
        m_MyAudioSource.Play();
        m_isPaused = true;
    }

}
