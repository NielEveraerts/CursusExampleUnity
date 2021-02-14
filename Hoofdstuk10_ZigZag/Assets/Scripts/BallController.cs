using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    Rigidbody rb;

    void Awake(){       //is opgeroepen voor de awake functie
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {   
        rb.velocity = new Vector3(speed,0,0);   //start met in de x as een velocity van speed te geven.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){       //bij elke linkermuisklik switchDirection()
            SwitchDirection();
        }
    }

    void SwitchDirection(){
        if(rb.velocity.x > 0){
            rb.velocity = new Vector3(0,0,speed);
        }
        else if(rb.velocity.z > 0){
            rb.velocity = new Vector3(speed,0,0);
        }
    }
}
