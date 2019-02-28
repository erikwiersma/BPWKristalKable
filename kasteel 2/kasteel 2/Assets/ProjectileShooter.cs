using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject prefab;
    public float Force = 500;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject nb = (GameObject)Instantiate(prefab, this.transform.position, this.transform.rotation);
            nb.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Force);
        }
    }
}
