using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheckPoint : MonoBehaviour
{
    public GameObject TriggerGiroCompleto;
    public GameObject TriggerCheckpoint;

    private void OnTriggerEnter(Collider other)
    {
        TriggerGiroCompleto.SetActive(true);
        TriggerCheckpoint.SetActive(false);
    }
}
