using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuoriStrada : MonoBehaviour
{
    public GameObject FuoriPista;
    public Rigidbody Auto;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColliderFuoriPista"))
        {
            Auto.drag = 0.7f;
            Debug.Log("Velocita abbassata");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ColliderFuoriPista"))
        {
            Auto.drag = 0.7f;
            Debug.Log("Velocita tenuta bassa");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ColliderFuoriPista"))
        {
            Auto.drag = 0.4f;
            Debug.Log("Velocita normale");
        }
    }
}
