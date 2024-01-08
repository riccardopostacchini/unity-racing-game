using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaricaTempoGiro : MonoBehaviour
{
    public int Minuti;
    public int Secondi;
    public float Millisecondi;
    public GameObject DisplayMinuti;
    public GameObject DisplaySecondi;
    public GameObject DisplayMillisecondi;

    void Start()
    {
        Minuti = PlayerPrefs.GetInt("MinSave");
        Secondi = PlayerPrefs.GetInt("SecSave");
        Millisecondi = PlayerPrefs.GetFloat("MilliSave");

        DisplayMinuti.GetComponent<Text>().text = "" + Minuti + ":";
        DisplaySecondi.GetComponent<Text>().text = "" + Secondi + ".";
        DisplayMillisecondi.GetComponent<Text>().text = "" + Millisecondi;
    }

}
