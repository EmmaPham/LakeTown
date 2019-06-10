using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidtext : MonoBehaviour {
    public GameObject guidetext;
    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {

            guidetext.gameObject.SetActive(true);


        }




    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            guidetext.gameObject.SetActive(false);
        }
    }
}
