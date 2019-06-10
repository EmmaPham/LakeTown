using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppCloser : MonoBehaviour {

    IEnumerator Start() 
    {
        // you should probably change something in the line below
        yield return new WaitForSeconds(77);
        SceneManager.LoadScene("main");
    }
}
