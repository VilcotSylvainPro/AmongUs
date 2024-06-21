using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    // Start is called before the first frame update



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Door") 
        {
            Debug.Log("Toucher la porte");
            other.gameObject.GetComponent<Animator>().SetBool("character_nearby", true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Door")
        {
            Debug.Log("J'ai franchis la porte");
            other.gameObject.GetComponent<Animator>().SetBool("character_nearby", false);
        }
    }


}
