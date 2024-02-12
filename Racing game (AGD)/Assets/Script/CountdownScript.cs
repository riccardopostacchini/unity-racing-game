using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject TimerGiroObj;
    public GameObject ControlliAuto;
    public GameObject CarUserControl;
    public AudioSource LevelMusic;
    

    void Start()
    {
        StartCoroutine(CountStart());
        TimerGiroObj.SetActive(false);
        CarUserControl.GetComponent<ControllerAuto>().enabled = false;
        TimerGiro.Minuti = 0;
        TimerGiro.Secondi = 0;
        TimerGiro.Millisecondi = 0;
    }

    IEnumerator CountStart ()
    {
        ControlliAuto.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "VIA!";
        GoAudio.Play();
        CountDown.SetActive(true);
        LevelMusic.Play();
        TimerGiroObj.SetActive(true);
        CarUserControl.GetComponent<ControllerAuto>().enabled = true;
        

        



    }
    
}
