using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int Mappa = 1;
    public GameObject M1 ;
    public GameObject M2 ;
    public GameObject M3 ;
    public GameObject M4 ;

    public void Esci()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }

    public void Indietro()
    {
        if(Mappa!=1)
        {
            Mappa = Mappa - 1;
        }
        if(Mappa==1)
        {
            M1.SetActive(true);
        }
        if(Mappa==2)
        {
            M2.SetActive(true);
        }
        if(Mappa==3)
        {
            M3.SetActive(true);
        }
        if(Mappa==4)
        {
            M4.SetActive(true);
        }
    }
    
    public void Avanti()
    {
        if(Mappa!=4)
        {
            Mappa = Mappa + 1;
        }
        if(Mappa==2)
        {
            M1.SetActive(false);
        }
        if(Mappa==3)
        {
            M2.SetActive(false);
        }
        if(Mappa==4)
        {
            M3.SetActive(false);
        }
    }
    
    public void Inizia()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + Mappa);
    }

}
