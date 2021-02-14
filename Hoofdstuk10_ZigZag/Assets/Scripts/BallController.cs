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

    public GameObject particle;

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

            GameManager.instance.GameOver();
        };

        if(!started){
            if(Input.GetMouseButtonDown(0)){       //bij elke linkermuisklik switchDirection()
                rb.velocity = new Vector3(speed,0,0);   //start met in de x as een velocity van speed te geven.
                started = true;

                GameManager.instance.StartGame();
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

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Diamond"){
            GameObject particleInstance = Instantiate(particle, col.gameObject.transform.position, Quaternion.identity);  //doen voordat je de diamond delete want anders kan je zijn positie niet meer vastkrijgen
            Destroy(col.gameObject);
            Destroy(particleInstance, 1f);  //anders blijven de particles veel te lang op het scherm
        }
    }
}
