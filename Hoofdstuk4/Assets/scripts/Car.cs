using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]   //hiermee kunnen we in de Unity Editor een Car object waarden geven mbv de constructor
public class Car
{  //geen monobehaviour omdat we hier geen gebruik van gaan maken, hierdoor gaan we dit script niet aan een gameObject kunnen toevoegen

    public float speed;
    public string color;
    public float highestSpeed;

    public Car()
    {
    }

    public Car(float speed, string color, float highestSpeed)
    {
        this.speed = speed;
        this.color = color;
        this.highestSpeed = highestSpeed;
        PrintDetailsOfCar();
    }



    public void Move()
    {
        Debug.Log("Moving");
    }

    public void Brake()
    {
        Debug.Log("Braking");
    }

    public void CarSpeed()
    {
        Debug.Log(speed);
    }

    public void PrintDetailsOfCar(){
        Debug.Log("speed = "+ speed);
        Debug.Log("color = "+ color);
        Debug.Log("maxSpeed = "+ highestSpeed);
    }
}
