using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerMove : MonoBehaviour
{
    float rotationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAcc = Input.acceleration.x;
        float zAcc = Input.acceleration.z;
        Debug.Log(xAcc);

        //transform.Translate(xAcc, 0, -zAcc * Time.deltaTime);   //verplaats in de x-as naar de waarde van de accelerometer en z-as

        transform.position += transform.forward * -zAcc * Time.deltaTime;   //andere manier van verplaatsen

        transform.Rotate(0, 0, -xAcc * rotationSpeed);      //nu roteren we in de z-as ook met temp zodat het vliegtuig kantelt naar de kant waar hij gaat
    }
}
