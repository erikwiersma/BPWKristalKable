using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KristalsoundScript : MonoBehaviour
{
    public GameObject Input;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetComponent<kabel>().State >= 2 && Input.GetComponent<kabel>().State <= 4)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
