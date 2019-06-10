using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmess : MonoBehaviour {
     AudioSource soundmeshfx;
   public float  volume;
    public bool alreadyPlay = false;
    public AudioClip soundtoplay;
    void Start()
    {
        soundmeshfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (!alreadyPlay)
        {   
            soundmeshfx.PlayOneShot(soundtoplay,volume);
            alreadyPlay = true;
           
        }
    }
}
