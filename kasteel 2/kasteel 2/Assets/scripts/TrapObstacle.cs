using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapObstacle : MonoBehaviour
{
    public GameObject ItSelf;
    public GameObject lift;
    public Transform Pos;
    public float hight = 5.0f;
    public float speed = 0.01f;

    void Start()
    {
        lift.transform.position = Pos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        lift.transform.position = new Vector3(Pos.transform.position.x, hight, Pos.transform.position.z);
        if (ItSelf.GetComponent<platform>().Power == true)
        {
            hight += speed;
            if (hight >= 15 || hight <= 5)
            {
                speed *= -1; 
            }
        }
    }
}
