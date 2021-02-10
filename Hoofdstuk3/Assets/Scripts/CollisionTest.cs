using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)        //de parameter bevat het object waarmee de bullet is in contact gekomen
    {
        if(col.gameObject.tag == "Enemy"){      //de objecten met Enemy zijn dus de enige objecten die destroyed worden als er contact is met de kogel
            Destroy(col.gameObject);            
        };
        Destroy(gameObject);                    //als het met iets in contact komt, destroy de kogel
        
    }
}
