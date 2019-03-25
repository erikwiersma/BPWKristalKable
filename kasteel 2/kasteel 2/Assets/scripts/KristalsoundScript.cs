using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KristalsoundScript : MonoBehaviour
{
    public GameObject Input;
    public float volumen; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetComponent<kabel>().State > 1 && Input.GetComponent<kabel>().State < 4)
        {
            //GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().volume = volumen;
        }
        else
        {
            //GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().volume = 0;
        }

    }
}
