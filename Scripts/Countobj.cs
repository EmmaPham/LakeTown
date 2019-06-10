using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countobj : MonoBehaviour {
    public GameObject SpiritTree;
     GameObject objUI;
    
	// Use this for initialization
	void Start () {
        objUI = GameObject.Find("Counttext");

	}
	
	// Update is called once per frame
	void Update () {
        objUI.GetComponent<Text>().text = Collect.objects.ToString();
        if (Collect.objects == 5 )
        {
            objUI.GetComponent<Text>().text = "All the Spirits collected, go to the Spiritual Tree to activate the power of Orb";
            SpiritTree.gameObject.SetActive(true);
        }
	}
}
