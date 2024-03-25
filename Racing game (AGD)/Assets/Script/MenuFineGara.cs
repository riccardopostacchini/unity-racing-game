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


    private void Update()
    {
        MinutiRecord = PlayerPrefs.GetInt("MinSave" + SceneManager.GetActiveScene().buildIndex);
        SecondiRecord = PlayerPrefs.GetInt("SecSave" + SceneManager.GetActiveScene().buildIndex);
        MillisecondiRecord = PlayerPrefs.GetFloat("MilliSave" + SceneManager.GetActiveScene().buildIndex);

        if (MinutiRecord <= 9)
        {
            DisplayMinuti.GetComponent<Text>().text = "0" + MinutiRecord + ":"; 
        }
        else
        {
            DisplayMinuti.GetComponent<Text>().text = "" + MinutiRecord + ":";
        }
        if (SecondiRecord <= 9)
        {
            DisplaySecondi.GetComponent<Text>().text = "0" + SecondiRecord + ".";
        }
        else
        {
            DisplaySecondi.GetComponent<Text>().text = "" + SecondiRecord + ".";
        }
        if (MillisecondiRecord <= 9)
        {
            DisplayMillisecondi.GetComponent<Text>().text = "0" + MillisecondiRecord;
        }
        else
        {
            DisplayMillisecondi.GetComponent<Text>().text = "" + MillisecondiRecord;
        }
            


    }

    
}
