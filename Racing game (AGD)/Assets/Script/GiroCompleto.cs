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

    public GameObject ContoGiri;
    public int GiriCompletati;

    private void OnTriggerEnter(Collider other)
    {
        GiriCompletati += 1;
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

    
            PlayerPrefs.SetInt("MinSave", TimerGiro.Minuti);
            PlayerPrefs.SetInt("SecSave", TimerGiro.Secondi);
            PlayerPrefs.SetFloat("MilliSave", TimerGiro.Millisecondi);
        

        TimerGiro.Minuti = 0;
        TimerGiro.Secondi = 0;
        TimerGiro.Millisecondi = 0;
        ContoGiri.GetComponent<Text>().text = "" + GiriCompletati; 

        Checkpoint.SetActive(true);
        GiroTrigger.SetActive(false);
        
    }
}
