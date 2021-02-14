using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;   //hiermee kan je op alle platformen de inputs ophalen 

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    void Awake(){
        rb = GetComponent<Rigidbody> ();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){     //physics based functionaliteit altijd in fixedupdate doen
        float hInput = CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vInput = CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime;

        rb.AddForce(hInput,0,vInput);   //voeg een force in de richting toe met de input.
    }
}
