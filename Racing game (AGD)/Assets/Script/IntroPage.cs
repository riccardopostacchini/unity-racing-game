using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPage : MonoBehaviour
{
    public GameObject intro ;
    public GameObject pmenu ;

    void Update()
    {
        if(intro.activeSelf)
        {
            StartCoroutine(sec());
        }
    }

    IEnumerator sec()
    {
        yield return new WaitForSeconds(1f);
        pmenu.SetActive(true);
        intro.SetActive(false);
        StopCoroutine(sec());
    }
}
