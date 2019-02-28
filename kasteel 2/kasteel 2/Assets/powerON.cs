using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerON : MonoBehaviour
{
    public GameObject Input;
    public GameObject partecles;
    public GameObject pickupObject;
    Rigidbody m_Rigidbody;
    // Update is called once per frame
    void Update()
    {
        m_Rigidbody = pickupObject.GetComponent<Rigidbody>();
        if (Input.GetComponent<kabel>().State == 2 || Input.GetComponent<kabel>().State == 3)
        {
            partecles.SetActive(true);
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }
        else
        {
            partecles.SetActive(false);
        }
    }
}
