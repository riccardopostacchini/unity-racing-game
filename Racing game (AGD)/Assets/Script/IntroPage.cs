using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPage : MonoBehaviour
{
    public GameObject intro = new GameObject();
    public GameObject pmenu = new GameObject();

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
