using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        Minuti = PlayerPrefs.GetInt("MinSave" + SceneManager.GetActiveScene().buildIndex);
        Secondi = PlayerPrefs.GetInt("SecSave" + SceneManager.GetActiveScene().buildIndex);
        Millisecondi = PlayerPrefs.GetFloat("MilliSave" + SceneManager.GetActiveScene().buildIndex);

        if (Minuti <= 9)
        {
            DisplayMinuti.GetComponent<Text>().text = "0" + Minuti + ":";
        }
        else
        {
            DisplayMinuti.GetComponent<Text>().text = "" + Minuti + ":";
        }
        if (Secondi <= 9)
        {
            DisplaySecondi.GetComponent<Text>().text = "0" + Secondi + "."; 
        }
        else
        {
            DisplaySecondi.GetComponent<Text>().text = "" + Secondi + ".";
        }
        if (Millisecondi <= 9)
        {
            DisplayMillisecondi.GetComponent<Text>().text = "0" + Millisecondi;
        }
        else
        {
            DisplayMillisecondi.GetComponent<Text>().text = "" + Millisecondi;
        }
            
    }

}
