using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    Renderer rend;
    public bool Power;
    public bool PowerKristal; //als er een vast stroom punt moet komen 
    void Start()
    {
        rend = GetComponent<Renderer>();
        Power = false;
    }
    void Update() 
    {
        if (PowerKristal == true)
        {
            
            Power = true;
        }
        if (Power == true)
        {
            rend.material.color = colorEnd;
        }
        else
        {
            rend.material.color = colorStart;
        }
    }

}