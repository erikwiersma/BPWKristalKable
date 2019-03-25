using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kristal_LIT_ook : MonoBehaviour
{
    public GameObject Input;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetComponent<platform>().Power == true)
        {
            GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
        else
        {
            GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }
}
