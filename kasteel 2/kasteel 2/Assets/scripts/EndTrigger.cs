
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject completeUI;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("hoi");
            completeUI.SetActive(true);
        }
    }
}