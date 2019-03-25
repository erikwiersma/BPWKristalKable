using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kraan : MonoBehaviour
{

    float Scrollx = 0.1f;
    public GameObject ItSelf;
    public GameObject DeKraan;
    public float Speed;

    public bool klokMee;
    public bool kloktegen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ItSelf.GetComponent<platform>().Power == true && klokMee == true) 
        {
            Scrollx = Speed;
            float offsetX = Time.time * Scrollx;
            DeKraan.gameObject.transform.Rotate(0, Scrollx, 0);
        }
        if (ItSelf.GetComponent<platform>().Power == true && kloktegen == true)
        {
            Scrollx = -Speed;
            float offsetX = Time.time * Scrollx;
            DeKraan.gameObject.transform.Rotate(0, Scrollx, 0);
        }
    }
}
