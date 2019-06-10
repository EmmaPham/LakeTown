using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winning : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene("x");
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("mainmenu");

    }

    public void exitgame()
    {
        Application.Quit();

    }
}
  