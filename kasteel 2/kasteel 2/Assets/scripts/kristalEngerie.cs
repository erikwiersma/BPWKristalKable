using UnityEngine;

public class kristalEngerie : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "KristalAan")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            transform.gameObject.tag = "KristalAan";
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "KristalAan")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            transform.gameObject.tag = "KristalAan";
        }

        if (other.gameObject.tag == "KristalUit")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            transform.gameObject.tag = "KristalUit";
        }

    }
    void OnTriggerExit(Collider other)
    {
        transform.gameObject.tag = "KristalUit";
    }
    // Update is called once per frame
    void Update()
    {

    }
}
