using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDoorgever : MonoBehaviour
{

    public GameObject ItSelf;
    public GameObject Input;

    void Update()
    {
        if (Input.GetComponent<platform>().Power == true)
        {
            ItSelf.GetComponent<platform>().Power = true;
        }
        else
        {
            ItSelf.GetComponent<platform>().Power = false;
        }
    }
}
