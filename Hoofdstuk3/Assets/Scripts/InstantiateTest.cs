using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{

    public GameObject[] balls; //in de unity edito gaan we de ball refereren naar deze var, belangrijk: refereer van de prefab folder, niet van het object zelf!!!!!

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, Quaternion.identity); //position is positie van het huidig gameonbject, kan dus ook iets anders zijn, Quaternion.identity betekent gewoon geen rotatie (0,0,0)
    
        Invoke("RandomBall", 5f);   //hiermee kan je de RandomBall functie 5 seconden na het straten activeren

        InvokeRepeating("RandomBall", 2f, 1f);  //hiermee kan je de funcite na 2 seconden na het starten, elke seconde de functie doen
    }

    // Update is called once per frame
    void Update()
    {
        // if( Input.GetMouseButtonDown(0)){
        //     int randomNumber = Random.Range(0,balls.Length);    //range(0,4) -> random getallen 0,1,2,3
        //     Instantiate(balls[randomNumber], transform.position, Quaternion.identity);  //spawn dus random 1 van de 3 gekleurde ballen bij elke linkermuisklik
        // }

        if( Input.GetMouseButtonDown(0)){
            print("Cancelled Generating");
            CancelInvoke("RandomBall");     //stop de Invoke methodes die RandomBall activeren
        }
    }

    void RandomBall(){
        int randomNumber = Random.Range(0,balls.Length);
        Instantiate(balls[randomNumber], transform.position, Quaternion.identity);
    }
}
