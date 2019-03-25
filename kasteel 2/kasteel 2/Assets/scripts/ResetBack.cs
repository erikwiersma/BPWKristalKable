using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBack : MonoBehaviour
{

    public GameObject End;
    public GameObject Spawn;
    Transform originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos.transform.position = Spawn.transform.position;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End" )
        {
            Debug.Log("the end");
            transform.position = new Vector3(Spawn.transform.position.x, Spawn.transform.position.y, Spawn.transform.position.z);
            End.transform.position = new Vector3(Spawn.transform.position.x, Spawn.transform.position.y, Spawn.transform.position.z);
        }
    }
}
