using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertext : MonoBehaviour
{
    public GameObject guidetext;
    public GameObject textUI;
    public GameObject cutscene;
    public GameObject player;

    bool IsPlayerCloseToTree()
    {
        return Vector3.Distance(gameObject.transform.position, player.transform.position) < 2;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsPlayerCloseToTree())
        {
            cutscene.gameObject.SetActive(true);
            guidetext.gameObject.SetActive(false);
            textUI.gameObject.SetActive(false);
            player.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {
           
            guidetext.gameObject.SetActive(false);
            textUI.gameObject.SetActive(true);

        }
        



    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            guidetext.gameObject.SetActive(true);
            textUI.gameObject.SetActive(false);
        }
    }
}
