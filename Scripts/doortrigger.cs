using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortrigger : MonoBehaviour {
    public GameObject _door;
 



    private void OnTriggerEnter() {
       
        _door.GetComponent<Animator>().SetBool("open", true); 

    }
    private void OnTriggerExit()
    {
        _door.GetComponent<Animator>().SetBool("open", false);
       
    }
 


}
