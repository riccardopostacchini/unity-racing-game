using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiroCompleto : MonoBehaviour
{
    public GameObject GiroTrigger;
    public GameObject Checkpoint;

    public GameObject Minuti;
    public GameObject Secondi;
    public GameObject Millisecondi;

    public GameObject BoxGiro;

    private void OnTriggerEnter(Collider other)
    {
        if (TimerGiro.Secondi <= 9)
        {
            Secondi.GetComponent<Text>().text = "0" + TimerGiro.Secondi + ".";
        }
        else
        {
            Secondi.GetComponent<Text>().text = "" + TimerGiro.Secondi + ".";
        }

        if (TimerGiro.Minuti <= 9)
        {
           Minuti.GetComponent<Text>().text = "0" + TimerGiro.Minuti + ".";
        }
        else
        {
            Minuti.GetComponent<Text>().text = "0" + TimerGiro.Minuti + ".";
        }

        Millisecondi.GetComponent<Text>().text = "" + TimerGiro.Millisecondi;

        TimerGiro.Minuti = 0;
        TimerGiro.Secondi = 0;
        TimerGiro.Millisecondi = 0;

        Checkpoint.SetActive(true);
        GiroTrigger.SetActive(false);
        
    }
}
