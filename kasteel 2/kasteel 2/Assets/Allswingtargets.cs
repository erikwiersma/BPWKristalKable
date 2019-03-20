using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allswingtargets : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Target4;
    public GameObject Target5;

    public float BrugDraaiSpeed;
    public float draaiLimit;

    private bool draai;
    public GameObject brug1;

    void Update()
    {
        if (Target1.GetComponent<kristalSwing>().Power == true && Target2.GetComponent<kristalSwing>().Power == true && Target3.GetComponent<kristalSwing>().Power == true && Target4.GetComponent<kristalSwing>().Power == true && Target5.GetComponent<kristalSwing>().Power == true)
        {
            draai = true;
        }
        if (draai == true)
        {
            Quaternion currentRotation = brug1.transform.rotation;
            Quaternion wantedRotation = Quaternion.Euler(0, draaiLimit, 0);
            brug1.transform.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation, Time.deltaTime * BrugDraaiSpeed);
            Target1.GetComponent<platform>().PowerKristal = true;
            Target2.GetComponent<platform>().PowerKristal = true;
            Target3.GetComponent<platform>().PowerKristal = true;
            Target4.GetComponent<platform>().PowerKristal = true;
            Target5.GetComponent<platform>().PowerKristal = true;
        }
            
        
    }
}
