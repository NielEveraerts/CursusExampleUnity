using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    GameObject searchObj;
    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        searchObj = GameObject.Find("Cube");

        searchObj = GameObject.Find("Cube/Cube2/Enemy");

        searchObj = GameObject.FindWithTag("Enemy");

        //Destroy(searchObj);


        enemies = GameObject.FindGameObjectsWithTag("Enemy");   //als meerdere objecten een tag hebben gebruik je deze ipv findWithTag

        foreach (GameObject enemy in enemies)                   // je kan niet een hele array van objecten destroyen dus moet je elk item mbv een for lus een voor een destroyen.
        {
            Destroy(enemy);                                     //je kan zo honderden objecten destroyen maar is niet aangeraden
        }

        GameObject.Find("Cube").SetActive(false);               //ook hier kan je meerdere acties in 1 lijn doen 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
