using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{
    public GameObject move;
    public float Force = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Untagged")
        {
            
            if (Input.GetKeyDown("space"))
                move.GetComponent<Rigidbody>().AddForce(Vector3.up * Force, ForceMode.Acceleration);
        }

    }
}
