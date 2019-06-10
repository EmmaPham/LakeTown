using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour {
    public GameObject Camera;
    public GameObject Playercamera;
    public GameObject Orb;
    public GameObject guidetext;
    public GameObject textUI;
    public float time = 0.0f;


	void Update () {

        time += Time.deltaTime;

            Camera.gameObject.SetActive(true);
            Playercamera.gameObject.SetActive(false);
             textUI.gameObject.SetActive(false);
        guidetext.gameObject.SetActive(false);

        if (time >= 10.0f)
            {
                Orb.gameObject.SetActive(true);
            }

            if (time >= 15.0f)

            {
                Playercamera.gameObject.SetActive(true);
                Camera.gameObject.SetActive(false);
                Orb.gameObject.SetActive(true);
            
            
            }
        


	}
}
