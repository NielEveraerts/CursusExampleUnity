using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    Rigidbody rb;

    PlayerHealth hp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.useGravity = false;
        rb.mass = 20;

        GetComponent<Renderer>().material.color = Color.red;

        hp = GetComponent<PlayerHealth>();                      //script verbonden aan hetzelfde gameobject kan ook binnengehaald worden metGetComponent
        //hp.lives = 9;

        GetComponents<Rigidbody>();                             //zo kan je meerdere componenten van hetzelfde type aanspreken die in hetzelfde object zitten

        GetComponentInChildren<Rigidbody>().useGravity = true;  //hier verander je de rigidbody van alle childobjecten van deze cube naar true (hier dus Cube2)
        GetComponentInParent<Rigidbody>().mass = 2;             //als het object een parent heeft kan je zijn components ook aanspreken 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
