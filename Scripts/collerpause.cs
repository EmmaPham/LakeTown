using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collerpause : MonoBehaviour
{
    public Transform optionmenu;
    public Transform pausemenuUI;

    // Update is called once per frame
    void Update()
    {

        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pausemenuUI.gameObject.SetActive(true);
                optionmenu.gameObject.SetActive(false);
            }




        }




    }
}


