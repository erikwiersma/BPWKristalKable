using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public GameObject Input;
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
        if (Power == true)
        {
            Input.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
        else
        {
            Input.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }

}