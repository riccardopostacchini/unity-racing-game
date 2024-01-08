using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject TimerGiro;
    public GameObject ControlliAuto;
    public GameObject CarUserControl;
    public AudioSource LevelMusic;
    void Start()
    {
        StartCoroutine(CountStart());
        TimerGiro.SetActive(false);
        CarUserControl.GetComponent<ControllerAuto>().enabled = false;
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
        GoAudio.Play();
        LevelMusic.Play();
        TimerGiro.SetActive(true);
        CarUserControl.GetComponent<ControllerAuto>().enabled = true;
    }
    
}
