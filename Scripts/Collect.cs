using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

    public static int objects = 5;
    


   

    void Awake () {
        objects--; // add one obj to static integer for every obj has this script
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider plyr) {
        if (plyr.gameObject.tag == "Player")//check if the player collider the obj
        {
         
            objects++;
            gameObject.SetActive(false); //if the player collider the obj, obj disappear
        }
	}
}
