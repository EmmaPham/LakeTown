using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertextcraft : MonoBehaviour {
    public GameObject textUI;


    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {
            textUI.gameObject.SetActive(true);
          


        }




    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textUI.gameObject.SetActive(false);
          
        }
    }
}
