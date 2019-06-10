using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introscript : MonoBehaviour {
    public GameObject Camera;
    public GameObject boat;
    public GameObject Playercamera;
    public GameObject guidetext;
    public GameObject gate;
    public GameObject counttext;
    public GameObject countobj;

    public float time = 0.0f;
    
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

        
        if (time >= 40.0f)
        {
            Camera.gameObject.SetActive(false);
            Playercamera.gameObject.SetActive(true);
            guidetext.gameObject.SetActive(false);
            boat.gameObject.SetActive(true);
            counttext.gameObject.SetActive(true);
            countobj.gameObject.SetActive(true);
        }

    }
}
