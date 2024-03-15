using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuoriStrada : MonoBehaviour
{
    public GameObject FuoriPista;
    public Rigidbody Auto;
    void OnCollisionEnter(Collision collision)
    {
        Auto.drag = 0.4f;
        Debug.Log("Velocita normale");
    }

    void OnCollisionStay(Collision collision)
    {
        Auto.drag = 0.4f;
        Debug.Log("Velocita tenuta normale");
    }
    void OnCollisionExit(Collision collision)
    {
        Auto.drag = 0.7f;
        Debug.Log("Velocita diminuita");
    }
}
