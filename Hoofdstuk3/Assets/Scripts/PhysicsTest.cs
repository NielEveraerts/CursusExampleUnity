using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{

    Rigidbody rb;
    float inputX, inputY;
    public float speed;
    public int jumpForce;
    bool jump = false;

    public GameObject bullet;
    public float bulletSpeed;
    bool shoot = false;
    public Transform bulletPos;

    void Awake(){                           //ook mogelijk om in start te doen maar best practice om in awake te doen
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = new Vector3(0,0,speed);   //we geven het object een velocity, vaste snlheid in de z-as
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        if(Input.GetButtonDown("Jump")){
            jump = true;                        //we willen springen = physics -> in FixedUpdate doen, dit met een bool, is die true dan gaat in fixedUpdate de jump functie uitgevoerd worden
        };

        if(Input.GetButtonDown("Fire1")){
            shoot = true;
        };
    }

    void FixedUpdate(){             //physics based functionaliteiten altijd via fixedUpdate doen aangezien dit meer reliable is
        rb.velocity = new Vector3(inputX * speed, rb.velocity.y, inputY * speed);       //beweeg in x en z op basis van input (vertical word dus naar voor of achter), en neem y waarde die al van pas was en herbruik die
        if(jump){                  
            Jump();
            jump = false;
        }
        if(shoot){
            Shoot();
            shoot = false;
        }
    }

    void Jump(){
        rb.AddForce(0, jumpForce, 0);
    }

    void Shoot(){
        GameObject spawnedBullet = Instantiate(bullet, bulletPos.position, bullet.transform.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed);              //zie dat het bulletPreFab een rigidBody heeft, anders kan je geen velocity geven aan het object
    }

    
}
