using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kristalSwing : MonoBehaviour
{
    // Fade the color from red to green
    // back and forth over the defined duration

    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    float duration = 1.0f;
    Renderer rend;
    public bool Power;


    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (GetComponent<platform>().Power == true)
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            //rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
            rend.material.color = colorStart;
            Power = true;
            Invoke("PowerOf", 3);
        }
            
    }
    void PowerOf()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        //rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
        rend.material.color = colorEnd;
        Power = false;
    }
}
