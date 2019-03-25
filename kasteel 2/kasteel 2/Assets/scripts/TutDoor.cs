using UnityEngine;

public class TutDoor : MonoBehaviour
{
    public GameObject ItSelf;
    public GameObject Door;
    
    public float Force = 12;
    public bool Destroy;
    public bool ISKinematic;
    public bool Heavy;
    private bool aan;
    
    public bool Up;
    public bool Left;
    public bool Right;
    public bool forward;
    public bool backward;

    void Start()
    {
        aan = false;

            if (Heavy == true)
        {
            Force = 40;
        }
        var Richting = Up;
    }
    void Update()
    {
        if (ItSelf.GetComponent<platform>().Power == true)
        {
            aan = true;
        }
        else
        {
            aan = false;
        }

        if (ISKinematic == false) //bool voor kinematic 
        {
            if (aan == true)
            {
                Door.GetComponent<Rigidbody>().isKinematic = false; // als platform AAN is = Kinematic Uit
            }   
        }
        // IS kinematic aan

        if (ISKinematic == true) //bool voor kinematic 
        {
            if (aan == true)
            {
                Door.GetComponent<Rigidbody>().isKinematic = false; // als platform AAN is = Kinematic Uit
            }
            else
            {
                Door.GetComponent<Rigidbody>().isKinematic = true;
            }
        }


        // Is kinematic uit



        if (aan == true  && Up == true) //UP
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.up * Force, ForceMode.Acceleration);
            Debug.Log("up");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }
        if (aan == true && Left == true) //LEFT
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.left * Force, ForceMode.Acceleration);
            Debug.Log("left");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }
        if (aan == true && Right == true) //RIGHT
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.right * Force, ForceMode.Acceleration);
            Debug.Log("right");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }
        if (aan == true && forward == true) //FORWARD
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.forward * Force, ForceMode.Acceleration);
            Debug.Log("forward");
            if (Destroy == true)
            {
                Invoke("DeActivate", 4);
            }
        }
        if (aan == true && backward == true) //BACKWARDS
        {
            Door.GetComponent<Rigidbody>().AddForce(Vector3.back * Force, ForceMode.Acceleration);
            Debug.Log("backwards");
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
