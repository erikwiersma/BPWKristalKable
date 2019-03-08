using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerON : MonoBehaviour
{
    public GameObject Input;
    public GameObject partecles;
    public GameObject pickupObject;
     
    void Update()
    {
        
        if (Input.GetComponent<kabel>().State == 2 || Input.GetComponent<kabel>().State == 3)
        {
            Input.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            partecles.SetActive(true);
        }
        else
        {
            Input.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            partecles.SetActive(false);
        }
    }
}
