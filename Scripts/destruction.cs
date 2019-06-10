using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class destruction : MonoBehaviour {
    public GameObject destroyobject;
    public GameObject player;
    public GameObject textUI;
    public GameObject soundmeshfx;



    //check if player close to the box
    bool IsPlayerCloseToBox ()
    {
        return Vector3.Distance(gameObject.transform.position, player.transform.position) < 3;

    }


    

    void Update () {
		if (Input.GetKeyDown(KeyCode.E) && IsPlayerCloseToBox())
        {
            soundmeshfx.SetActive(true);
            Instantiate(destroyobject, transform.position, transform.rotation);
            
            Destroy(gameObject);
            
            
            textUI.gameObject.SetActive(false);
           

            
        }
	}
}
