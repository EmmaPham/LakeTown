using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove : MonoBehaviour {
  
    IEnumerator Start()
    {
       
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
