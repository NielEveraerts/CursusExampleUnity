using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider){             //belangrijk dat je de functie juist staat
        if(collider.gameObject.tag == "Player"){
            //score++ ofzoiets
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag == "Boundary"){
            //verlaag levens
            Destroy(gameObject);
        }
    }
}
