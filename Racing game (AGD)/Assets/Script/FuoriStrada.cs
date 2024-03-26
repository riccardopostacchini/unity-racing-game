using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuoriStrada : MonoBehaviour
{
    // Riferimento al rigidbody dell'auto
    public Rigidbody Auto;

    // Riferimento al collider del detector di strada
    public Collider Detector;

    // Valore di drag normale sull'asfalto
    public float normalDrag = 0f;

    // Valore di drag quando l'auto è fuori strada
    public float offRoadDrag = 0.2f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FuoriPista"))
        {
            // Se l'auto entra nel trigger della strada, imposta il drag normale
            Auto.drag = offRoadDrag;
            Debug.Log("Attrito aumentato");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("FuoriPista"))
        {
            // Se l'auto esce dal trigger della strada, imposta il drag maggiore
            Auto.drag = normalDrag;
            Debug.Log("Attrito normale");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("FuoriPista"))
        {
            // Se l'auto rimane nel trigger della strada, imposta il drag normale
            Auto.drag = offRoadDrag;
            Debug.Log("Attrito aumentato");
        }
    }
}

