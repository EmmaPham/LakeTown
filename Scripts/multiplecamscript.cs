using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplecamscript : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(15);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);

        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        yield return new WaitForSeconds(5);
        cam4.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam5.SetActive(false);
        yield return new WaitForSeconds(17);
        cam5.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);



    }
}
