﻿using UnityEngine;

public class kristalMother : MonoBehaviour
{
    public GameObject Motherkristal;
    private Vector3 KristalPosition;
    void Update()
    {
        
    }
    void OnTriggerStay(Collider startPlatform)
    {
        if (Motherkristal.GetComponent<PickUp>().isHolding == false)
        {
            Motherkristal.GetComponent<PickUp>().check = false;
        }
    }

}
