using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FineGara : MonoBehaviour
{
    public GameObject Auto;
    public GameObject CameraFinish;
    public GameObject ViewModes;
    public GameObject BGMLivello;
    public GameObject TriggerCompleto;
    public GameObject BoxGiri;
    public GameObject BoxTimer;
    public AudioSource MusicaFinish;

    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Auto.SetActive(false);
        TriggerCompleto.SetActive(false);
        ControllerAuto.MoveSpeed = 0.0f;
        BoxGiri.SetActive(false);
        BoxTimer.SetActive(false);
        Auto.GetComponent<ControllerAuto>().enabled = false;
        Auto.SetActive(true);
        CameraFinish.SetActive(true);
        BGMLivello.SetActive(false);
        ViewModes.SetActive(false);
        MusicaFinish.Play();
    }
}
