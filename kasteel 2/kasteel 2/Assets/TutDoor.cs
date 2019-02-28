using UnityEngine;

public class TutDoor : MonoBehaviour
{
    public GameObject ItSelf;
    public GameObject Door;
    public float Force = 12;
    public bool Destroy;
    public bool Heavy;

    
    public bool Up;
    public bool Left;
    public bool Right;
    public bool forward;
    public bool backward;

    void Start()
    {
        if (Heavy == true)
        {
            Force = 40;
        }
        var Richting = Up;
    }
    void Update()
    {

        if (ItSelf.GetComponent<platform>().Power == true  && Up == true) 
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.up * Force, ForceMode.Acceleration);
            Debug.Log("open");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }
        if (ItSelf.GetComponent<platform>().Power == true && Left == true)
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.left * Force, ForceMode.Acceleration);
            Debug.Log("left");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }
        if (ItSelf.GetComponent<platform>().Power == true && Right == true)
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.right * Force, ForceMode.Acceleration);
            Debug.Log("right");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }
        if (ItSelf.GetComponent<platform>().Power == true && forward == true)
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.forward * Force, ForceMode.Acceleration);
            Debug.Log("right");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }
        if (ItSelf.GetComponent<platform>().Power == true && backward == true)
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.back * Force, ForceMode.Acceleration);
            Debug.Log("right");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }

    }
    void DeActivate()
    {
        Destroy(Door);
    }
}
