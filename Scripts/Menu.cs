using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public GameObject cameraplayer;
    public GameObject trigger;
    public GameObject trigger1;
    public GameObject videocam;
    public GameObject text;
    void Start()
    {
        
        cameraplayer.SetActive(false);
        trigger.SetActive(false);
        trigger1.SetActive(false);
        text.SetActive(false);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("main");
        videocam.SetActive(false);
    }

    public void PlayAgain()
    {

        SceneManager.LoadScene("fps");
        videocam.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        videocam.SetActive(false);

    }

}
