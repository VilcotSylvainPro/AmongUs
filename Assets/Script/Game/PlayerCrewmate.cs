using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerCrewmate : MonoBehaviour
{

    private bool Utiliser;
    private bool Corps = false;
    private bool Emergency = false;


    private bool TachePrimeShield;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Valeur bool Utiliser = " + Utiliser);
        //Debug.Log("Valeur bool TachePrimeShield = " + TachePrimeShield);
    }

    public bool ReturnEmergency()
    {
        return Emergency;
    }


    public bool ReturnUtiliser()
    {
        return Utiliser;
    }

    public bool ReturnPrimeShield()
    {
        return TachePrimeShield;
    }


    public bool ReturnCorps()
    {
        return Corps;
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Task" && other.gameObject.name == "TachePrimeShieldsActivator")
        {
            Debug.Log("Je peux utiliser");
            Utiliser = true;
            TachePrimeShield = true;

        }
        if (other.gameObject.tag == "Corps")
        {
            Debug.Log("Je touche un cadavre");
        }
        if (other.gameObject.tag == "Emergency")
        {
            Debug.Log("Je touche boutonEmergency");
            Emergency = true;
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Task" && other.gameObject.name == "TachePrimeShieldsActivator")
        {
            Debug.Log("Je peux utiliser (STay)");
            Utiliser = true;
            TachePrimeShield = true;


        }
        if (other.gameObject.tag == "Corps")
        {
            Debug.Log("Je touche un cadavre");
        }
        if (other.gameObject.tag == "Emergency")
        {
            Debug.Log("Je touche boutonEmergency");
            Emergency = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Task" && other.gameObject.name == "TachePrimeShieldsActivator")
        {
            Debug.Log("Je Sort (Exit)");
            Utiliser = false;
            TachePrimeShield = false;
        }
        if (other.gameObject.tag == "Emergency")
        {
            Debug.Log("Je touche boutonEmergency");
            Emergency = false;
        }

    }

}
