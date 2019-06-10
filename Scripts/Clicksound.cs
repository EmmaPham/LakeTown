using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Clicksound : MonoBehaviour {
    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverFx);
    }
    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }
}
