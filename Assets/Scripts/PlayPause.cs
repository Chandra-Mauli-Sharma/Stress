using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPause : MonoBehaviour
{
    AudioSource m_MyAudioSource;

    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.A))
        {
            m_MyAudioSource.UnPause();
        }
        else
        {
            m_MyAudioSource.Pause();
        }
    }

}
