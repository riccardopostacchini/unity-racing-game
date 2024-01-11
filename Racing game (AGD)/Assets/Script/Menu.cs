using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int Mappa = 1;
    public GameObject M1 = new GameObject();
    public GameObject M2 = new GameObject();
    public GameObject M3 = new GameObject();
    public GameObject M4 = new GameObject();
    public GameObject M5 = new GameObject();


    public void Esci()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }

    public void Opzioni()
    {
       
    }

    public void Record()
    {
        
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
        if(Mappa==2)
        {
            M3.SetActive(true);
        }
        if(Mappa==3)
        {
            M4.SetActive(true);
        }
        if(Mappa==4)
        {
            M5.SetActive(true);
        }
    }
    
    public void Avanti()
    {
        if(Mappa!=5)
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
        if(Mappa==5)
        {
            M4.SetActive(false);
        }
    }
    
    public void Inizia()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + Mappa);
    }
}
