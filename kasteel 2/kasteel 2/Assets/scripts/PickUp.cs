using System;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public float pickUpDistance = 4f;
    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    private bool isHolding = false;
    public bool check = true;
    public float trowFroce = 600f;
    Vector3 objectPos;
    float distance;

    public Boolean IsHolding
    {
        get
        {
            return isHolding;
        }

        set
        {
            isHolding = value;
        }
    }



    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
        if (distance >= pickUpDistance )
        {
            IsHolding = false;
        }
        //check if isHolding
        if (IsHolding == true && check == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

            if (Input.GetMouseButtonDown(1))        //muis input rechts 
            {
                item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * trowFroce);      //om het object weg te schieten 
                IsHolding = false;
            }
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }
    void OnMouseDown()
    {
        if (distance <= pickUpDistance)                                 //kijkt of de afstand groter is dan de oppak afstand
        {
            IsHolding = true;                                           //bool van de ifstatement AAN
            item.GetComponent<Rigidbody>().useGravity = false;          //zet de zwaartekracht van de rigidboy uit
            item.GetComponent<Rigidbody>().detectCollisions = true;     //zet de collision detection aan    
        }
    }
    void OnMouseUp()
    {
        IsHolding = false;                                              //bool van de ifstatement UIT
    }

}   

