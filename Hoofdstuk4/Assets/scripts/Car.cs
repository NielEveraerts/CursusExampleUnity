using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car  {  //geen monobehaviour omdat we hier geen gebruik van gaan maken, hierdoor gaan we dit script niet aan een gameObject kunnen toevoegen

    public float speed;
    public string color;
    public float highestSpeed;

    public void Move(){
        Debug.Log("Moving");
    }

    public void Brake(){
        Debug.Log("Braking");
    }

    public void CarSpeed(){
        Debug.Log(speed);
    }
}
