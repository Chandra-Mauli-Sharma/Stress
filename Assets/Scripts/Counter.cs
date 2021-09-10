using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text text;
    float count;
    Camera m_MainCamera;
    public Camera m_CameraTwo;
    // Start is called before the first frame update
    void Start()
    {
        count=30;
        m_MainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if((count>=0)&&m_MainCamera.enabled==true)
        {
            count=count-Time.deltaTime;
            text.text=Mathf.Ceil(count).ToString();
        }
        else
        {
            m_MainCamera.enabled = false;
            m_CameraTwo.enabled = true;
            Trigger.count=0;
            count = 30;
        }
    }
}
