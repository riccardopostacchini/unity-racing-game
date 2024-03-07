using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGiro : MonoBehaviour
{
    public static int Minuti;
    public static int Secondi;
    public static float Millisecondi;
    public static string Millidisplay;

    public GameObject BoxMinuti;
    public GameObject BoxSecondi;
    public GameObject BoxMillisecondi;

    public static float RawTime;


    void Update()
    {
        Millisecondi += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        Millidisplay = Millisecondi.ToString("F0");
        BoxMillisecondi.GetComponent<Text> ().text = "" + Millidisplay;

        if (Millisecondi >= 10)
        {
            Millisecondi = 0;
            Secondi += 1;
        }

        if (Secondi  <= 9)
        {
            BoxSecondi.GetComponent<Text>().text = "0" + Secondi + ".";
        }
        else
        {
            BoxSecondi.GetComponent<Text>().text = "" + Secondi + ".";
        }

        if (Secondi >= 60)
        {
            Secondi = 0;
            Minuti += 1;
        }

        if (Minuti <= 9)
        {
            BoxMinuti.GetComponent<Text>().text = "0" + Minuti + ":";
        }
        else
        {
            BoxMinuti.GetComponent<Text>().text = "" + Minuti + ":";
        }
    }
}
