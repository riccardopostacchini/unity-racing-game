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

    public float RawTime;

    public GameObject FineGara;

    private void Start()
    {
        GiriCompletati = 1;
    }
    private void Update()
    {
        if (GiriCompletati == 1)
        {
            FineGara.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GiriCompletati += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (TimerGiro.RawTime <= RawTime)
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
                Minuti.GetComponent<Text>().text = "0" + TimerGiro.Minuti + ":";
            }
            else
            {
                Minuti.GetComponent<Text>().text = "0" + TimerGiro.Minuti + ":";
            }

            Millisecondi.GetComponent<Text>().text = "" + TimerGiro.Millisecondi;
        }
    
            PlayerPrefs.SetInt("MinSave", TimerGiro.Minuti);
            PlayerPrefs.SetInt("SecSave", TimerGiro.Secondi);
            PlayerPrefs.SetFloat("MilliSave", TimerGiro.Millisecondi);
            PlayerPrefs.SetFloat("RawTime", TimerGiro.RawTime);

       
        TimerGiro.Minuti = 0;
        TimerGiro.Secondi = 0;
        TimerGiro.Millisecondi = 0;
        TimerGiro.RawTime = 0;
        ContoGiri.GetComponent<Text>().text = "" + GiriCompletati; 

        Checkpoint.SetActive(true);
        GiroTrigger.SetActive(false);
        
    }
}
