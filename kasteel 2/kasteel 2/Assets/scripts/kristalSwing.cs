using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kristalSwing : MonoBehaviour
{
    // Fade the color from red to green
    // back and forth over the defined duration


    float duration = 1.0f;
    public bool Power;


    void Update()
    {
        if (GetComponent<platform>().Power == true)
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            Power = true;
            if (GetComponent<platform>().PowerKristal == false)
            {
                Invoke("PowerOf", 3);
            }
        }
            
    }
    void PowerOf()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        Power = false;
    }
}
