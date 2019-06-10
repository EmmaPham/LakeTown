using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class esc : MonoBehaviour {

    public Transform mainmenu;
    public Transform introduction;
    public Transform quitmenu;
    public Transform credit;
    public Transform option;
      
    // Update is called once per frame
    void Update ()
    {
        
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (mainmenu.gameObject.activeInHierarchy == false)
                {

                    mainmenu.gameObject.SetActive(true);
                    introduction.gameObject.SetActive(false);
                    quitmenu.gameObject.SetActive(false);
                    credit.gameObject.SetActive(false);
                    option.gameObject.SetActive(false);

                }
                
               


            }


            
            
        }
    }
}

