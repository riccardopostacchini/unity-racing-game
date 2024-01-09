using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotazioneFinish : MonoBehaviour
{
    public float velocitaRotazione = 1.0f; 
    void Update()
    {
        float angoloDiRotazione = velocitaRotazione * Time.deltaTime;
        transform.Rotate(0, angoloDiRotazione, 0, Space.World);
    }
}
