using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject Pausa;

    public static bool inPausa;
    void Start()
    {
        Pausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                if (inPausa)
            {
                RiprendiGioco();
            }
                else
            {
                PausaGioco();
            }
        }
    }

    public void PausaGioco()
    {
        Pausa.SetActive(true);
        Time.timeScale = 0f;
        inPausa = true;

    }

    public void RiprendiGioco()
    {
        Pausa.SetActive(false);
        Time.timeScale = 1f;
        inPausa = false;
    }

    public void TornaAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menù");
    }

    public void Riprova ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }
}
