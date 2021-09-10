using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Trigger : MonoBehaviour
{
    public Text text;
    public Text High;
    public static int count;
    // Start is called before the first frame update
    void Start()
    {
        count=0;
        High.text=PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionStay(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Road")
        {
            count=count+1;
            text.text=count.ToString();
            if(count>=PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore",count);
                High.text=PlayerPrefs.GetInt("HighScore",count).ToString();
            }
        }
    }
}
