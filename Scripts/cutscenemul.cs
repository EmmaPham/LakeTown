using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscenemul : MonoBehaviour {
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject playercam;
    public GameObject menu;
	// Use this for initialization
	void Start () {
	    StartCoroutine (TheSequence());
        playercam.SetActive(false);
        menu.SetActive(true);
	}
	
	IEnumerator TheSequence()
    {
        
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);

        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
       
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(4);
        cam2.SetActive(true);
        cam1.SetActive(false);
        cam3.SetActive(false);
        yield return new WaitForSeconds(5);
        cam3.SetActive(true);
        cam2.SetActive(false);
        cam1.SetActive(false);
        yield return new WaitForSeconds(10);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
    }
}
