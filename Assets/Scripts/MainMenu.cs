using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    Camera m_MainCamera;
    public Camera m_CameraTwo;

    void Start()
    {
        m_MainCamera = Camera.main;
        m_MainCamera.enabled = false;
        m_CameraTwo.enabled = true;
    }

    void Update()
    {
        
    }

    public void change()
    {
        m_MainCamera.enabled = true;
        m_CameraTwo.enabled = false;
    }
}
