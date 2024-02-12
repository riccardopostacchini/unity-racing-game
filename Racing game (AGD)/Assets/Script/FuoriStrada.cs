using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuoriStrada : MonoBehaviour
{
    public GameObject FuoriPista;
    public Rigidbody Auto;
    private void OnTriggerEnter(Collider other)
    {
        Auto.drag = 1f;
        Debug.Log("Velocit� diminuita");
    }

    private void OnTriggerExit(Collider other)
    {
        Auto.drag = 0.3f;
        Debug.Log("Velocit� aumentata"); 
    }
}
