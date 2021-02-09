using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2GetComponents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Cube").GetComponent<PlayerHealth>().lives = 9;         //component aanspreken vanuit een ander gameobject
        GameObject.Find("Cube").GetComponent<Rigidbody>().drag = 1;             //niet aangeraden om bijvoorbeeld in update te doen aangezien dit een vrij lange taak is voor iets simpel, beter dat je de referentie opslaat in een variable om zo dan eigenschappen constant te updaten
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
