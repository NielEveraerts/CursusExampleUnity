using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    bool started = false;
    bool gameOver = false;

    Rigidbody rb;

    void Awake(){       //is opgeroepen voor de awake functie
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        if(!Physics.Raycast(transform.position, Vector3.down, 1f)){  //positie van bal, ray naar beneden, en lengte van 1 -> als de ray niets raakt maak gameOver = true
            gameOver = true;
            //rb.velocity = new Vector3(rb.velocity.x,-25f,rb.velocity.y);      //in cursus is gravity afgezet en voeg je handamatig verticale velocity toe, ik vind dat onnuttig en gebruik ingebouwde gravity
            Camera.main.GetComponent<CameraFollow>().gameOver = true;           //get gameOver van het script van de main camera
        };

        if(!started){
            if(Input.GetMouseButtonDown(0)){       //bij elke linkermuisklik switchDirection()
                rb.velocity = new Vector3(speed,0,0);   //start met in de x as een velocity van speed te geven.
                started = true;
            }
        }
        else{
            if(Input.GetMouseButtonDown(0) && !gameOver){       //bij elke linkermuisklik switchDirection()
                SwitchDirection();
            }
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
