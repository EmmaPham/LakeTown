using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E17_startAnimation : MonoBehaviour {

    void OnTriggerEnter()
    {
        Animator gateAnim = gameObject.GetComponent<Animator>();
        gateAnim.Play("Closing");
    }
void OnTriggerExit()
    {
        Invoke("Reset", 4.5f);
    }
    void Reset()
    {
        Animator gateAnim = gameObject.GetComponent<Animator>();
        gateAnim.Play("opening");
    }
}
