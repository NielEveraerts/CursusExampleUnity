using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider col){                                              //als een object in dit object komt, start deze functie
        col.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    void OnTriggerExit(Collider col){                                              //als een object uit dit object gaat, start deze functie
        col.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    void OnTriggerStay(Collider col){                                              //zo lang een object in dit object zit, word deze functie uigevoerd, ook weer een soort van while die constant uitgevoerd word wanneer je in het object zit
        print("in DeadZone");
    }
}
