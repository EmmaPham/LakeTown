using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggercutsceneending : MonoBehaviour {
    public GameObject cutscene;
    public GameObject playercamera;
    public Material skybox1;
    public Material skybox2;
    public GameObject triggercutscene;
    

    // Use this for initialization
    void Start () {
        RenderSettings.skybox = skybox1;
        
	}

     void OnTriggerEnter(Collider player)

     {
        
        if (player.gameObject.tag == "Player")
        {
            triggercutscene.SetActive(false);
            cutscene.SetActive(true);
            playercamera.SetActive(false);
            RenderSettings.skybox = skybox2;
            
        }
       }
    }
    
        
    
  