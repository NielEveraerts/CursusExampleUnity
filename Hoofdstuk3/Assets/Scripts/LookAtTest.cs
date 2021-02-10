using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTest : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.transform.position.x,transform.position.y, target.transform.position.z);   //hiermee zal het object kijken naar het ander object enkel in de x-as, in de y en z as blijft hij op zijn eigen coordinaten 
        //het is aangeraden om toch minstens op 2 assen te laten roteren naar de target, anders gaat dit niet volledig juist werken
        transform.LookAt(target.transform); //volgt volledig de target

        //transform.LookAt(newPos);         //hier kijkt hij enkel in de x en z as, niet y as 
    }
}
