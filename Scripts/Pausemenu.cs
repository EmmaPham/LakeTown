using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Pausemenu : MonoBehaviour {
    public Transform Player;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Canvas exitmenu;
    public Canvas optionmenu;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();

            }
        }



	}

     public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Player.GetComponent<FirstPersonController>().enabled = true;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Player.GetComponent<FirstPersonController>().enabled = false;
    }


    public void LoadMenu ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainmenu", LoadSceneMode.Single);

    }

    public void openquitmenu()
    {
        pauseMenuUI.SetActive(false);
        exitmenu.gameObject.SetActive(true);
        
    }

    public void noquit ()

    {
            

        pauseMenuUI.SetActive(true);
        exitmenu.gameObject.SetActive(false);

    }

    public void openoption()
    {
      
            pauseMenuUI.SetActive(false);
            optionmenu.gameObject.SetActive(true);

    }

    public void escoption()
    { 
           pauseMenuUI.SetActive(true);
           optionmenu.gameObject.SetActive(false);
        
    }
   

    public void QuitGame ()
    {
        Application.Quit();

    }

}
