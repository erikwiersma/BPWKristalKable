using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kabel : MonoBehaviour
{
    public GameObject DeLink;       //Het andere kristal
    public float State;             //De status van het kristal

    void Start()
    {
        //State 1 = uit
        //State 2 = child
        //State 3 = parent
        //State 4 = child shutdown
        State = 1;
    }
        void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<platform>().Power == true && State <= 3) //check of het een child is. 
        {
            if (State == 1)                                             //if Status == uit wordt parent
            {
                State = 3;                                              //Zet parent
                DeLink.GetComponent<kabel>().State = 2;                 //Zet child  
            }
        }
    }
    void OnTriggerStay(Collider other)
    {

        if (other.GetComponent<platform>().Power == true && State <= 3) //if child
        {
            if (State == 1)                                             //if Status == uit wordt parrent
            {
                State = 3;                                              //Zet parent
                DeLink.GetComponent<kabel>().State = 2;                 //Zet child
            }

        }
        if (State == 4)                                                 //als parrent los wordt gekoppeld wordt child State 4 
        {                                                               //State 4 is voor het uitzetten van het andere platform
            other.GetComponent<platform>().Power = false;               //uizetten Delink-platform
            State = 1;                                                  //Zet state naar Uit
        }
        if (State == 2 || State == 3 )                                  //if child or parrent 
        {
            other.GetComponent<platform>().Power = true;                //Zet platform aan
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (State == 3)                                                 //if parrent gaat er uit
        {
            State = 1;                                                  //zet parrent Uit
            other.GetComponent<platform>().Power = false;               //zet platform Uit
            DeLink.GetComponent<kabel>().State = 4;                     //zet Delink Platfom uit in Trigger-stay
        }
        if (State == 2)                                                 //if child gaat er uit
        {
            other.GetComponent<platform>().Power = false;               //zet platform uit   
        }
    }
    
}