using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.tag == "Ball"){
            Invoke("FallDown", 0.5f);       //invoke start functie na meegegeven tijd.
        }
    }

    void FallDown(){
        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;

        Destroy(transform.parent.gameObject,2f);    //na 2 seconden destroy de parent gameobject
    }
}
