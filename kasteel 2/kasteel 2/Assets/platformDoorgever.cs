using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDoorgever : MonoBehaviour
{

    public GameObject Input;
    public GameObject start;
    public GameObject end;

    void Update()
    {
        if (GetComponent<platform>().Power == true)
        {
            //GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            Input.GetComponent<platform>().Power = true;
            start.GetComponent<kabel>().State = 3;
            end.GetComponent<kabel>().State = 2;
        }
        else
        {
            //GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            Input.GetComponent<platform>().Power = false;
            start.GetComponent<kabel>().State = 0;
            end.GetComponent<kabel>().State = 0;
        }
    }
}
