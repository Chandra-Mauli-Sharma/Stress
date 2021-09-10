using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject planet ;
    public GameObject car;
    Camera m_MainCamera;
    void Start()
    {
        m_MainCamera=Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_MainCamera.enabled==true)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                planet.transform.Rotate(0.0f, -10.0f*Time.deltaTime, 0.0f*Time.deltaTime, Space.Self);
            }
            if(Input.GetKey(KeyCode.A))
            {
                planet.transform.Rotate(5.0f*Time.deltaTime, 0.0f*Time.deltaTime, 0.0f*Time.deltaTime, Space.Self);
                car.transform.Rotate(0.0f*Time.deltaTime, -10.0f*Time.deltaTime, 0.0f*Time.deltaTime, Space.Self);
            }
            if(Input.GetKey(KeyCode.D))
            {
                planet.transform.Rotate(-5.0f*Time.deltaTime, 0.0f*Time.deltaTime, 0.0f*Time.deltaTime, Space.Self);
                car.transform.Rotate(0.0f*Time.deltaTime, 10.0f*Time.deltaTime, 0.0f*Time.deltaTime, Space.Self);
            }
        }

    }
}
