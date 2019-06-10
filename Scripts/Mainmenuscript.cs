using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenuscript : MonoBehaviour {
    public void FlyThrough()
    {
        SceneManager.LoadScene("flythrough");

    }

    public void Fps()
    {

        SceneManager.LoadScene("fps");
    }

    public void Quit()
    {
        Application.Quit();

    }
}
