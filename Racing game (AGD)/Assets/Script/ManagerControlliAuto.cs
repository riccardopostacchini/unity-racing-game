using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerControlliAuto : MonoBehaviour
{
    public GameObject CarControl;


void Start () {

    
    CarControl.GetComponent<PrometeoCarController>().enabled = true;
    
    }
}
