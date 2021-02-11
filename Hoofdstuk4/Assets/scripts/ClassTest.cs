using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Car myCar = new Car();                          //niet nodig om Car class te importen
        myCar.speed = 10.5f;
        myCar.color = "red";
        myCar.highestSpeed = 150f;

        myCar.CarSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
