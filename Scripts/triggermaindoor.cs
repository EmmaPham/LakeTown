using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggermaindoor : MonoBehaviour {

    public GameObject _maingate;




    private void OnTriggerEnter(Collider camera)
    {
        if (camera.gameObject.tag == "camera")
        { _maingate.GetComponent<Animator>().SetBool("opengate", true); }

    }
    private void OnTriggerExit(Collider camera)
    {
        if (camera.gameObject.tag == "camera")
        { _maingate.GetComponent<Animator>().SetBool("opengate", false); }

    }
}
