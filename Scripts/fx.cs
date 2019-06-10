using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fx : MonoBehaviour
{
    public AudioSource Fx;
    // Use this for initialization
    void Start()
    {
        Fx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")//check if the player collider the obj
        {
            Fx.Play();
        }
    }
}
