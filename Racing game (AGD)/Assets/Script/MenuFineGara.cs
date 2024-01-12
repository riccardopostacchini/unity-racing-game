using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuFineGara : MonoBehaviour
{
    public int MinutiRecord;
    public int SecondiRecord;
    public float MillisecondiRecord;
    public GameObject DisplayMinuti;
    public GameObject DisplaySecondi;
    public GameObject DisplayMillisecondi;


    private void Start()
    {
        MinutiRecord = PlayerPrefs.GetInt("MinSave");
        SecondiRecord = PlayerPrefs.GetInt("SecSave");
        MillisecondiRecord = PlayerPrefs.GetFloat("MilliSave");

        DisplayMinuti.GetComponent<Text>().text = "" + MinutiRecord + ":";
        DisplaySecondi.GetComponent<Text>().text = "" + SecondiRecord + ".";
        DisplayMillisecondi.GetComponent<Text>().text = "" + MillisecondiRecord;


    }

    
}
