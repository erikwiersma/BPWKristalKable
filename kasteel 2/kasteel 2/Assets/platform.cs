using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public bool Power;
    public bool PowerKristal; //als er een vast stroom punt moet komen 
    void Start()
    {
        Power = false;
    }
    void Update() 
    {
        if (PowerKristal == true)
        {
            Power = true;
        }
    }

}