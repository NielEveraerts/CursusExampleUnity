using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTestScript : MonoBehaviour
{

    Vector3 position;   //bevat een X, Y en Z waarde

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(1f,2f,3f);           //vector3 accepteert enkel floats
        print(transform.position);  	            //je kan de waarde printen van de transform component zonder getComponent te doen
        transform.position = new Vector3(0,0,0);    //je kan niet zomaar transform.position.x ++ doen, je moet altijd een nieuw Vector object aanmkaen en die waarde aan de position geven

        transform.position += new Vector3(1f,0,0);  //je kan dus ook de waarde van een Vector object bij optellen aan de huidige waarde van position
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0.1f,0.1f,0); 
        transform.position += transform.up * speed;     //position met vectors updaten gaat, maar deze manier is beter, zo is het ook makkelijk om de snelheid ervan aan te passen dus => (0, speed, 0)
        transform.Translate(speed,0,0);                 //de kortste manier om position te updaten, met Translate kan je direct waardes meegeven zonder zelf een Vector object aan te maken
    
        transform.Rotate(0,speed, 0);                   //zo kan je ook het gameObject laten draaien rond de 3 assen 

        //transform.localScale += new Vector3(0,speed,0); 
        transform.localScale += transform.up * speed;   //ook kan je dus de scale veranderen
        //al deze manieren kunnen gebruikt worden en het is vooral eigen voorkeur welke manier je gebruikt
    }
}
