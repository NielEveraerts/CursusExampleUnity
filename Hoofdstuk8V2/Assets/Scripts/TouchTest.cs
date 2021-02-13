using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    Ray ray;

    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0){
            Debug.Log(Input.GetTouch(0).position);       //bevat position info van in dit geval de eerste aanraking met een scherm ()
            foreach (Touch touch in Input.touches)      //touches is array van alle touches
            {
                Debug.Log(touch.position);
            }

            if(Input.GetTouch(0).phase == TouchPhase.Began){
                Debug.Log("touch begonnen");
            }
            if(Input.GetTouch(0).phase == TouchPhase.Stationary){
                Debug.Log("touch stilhouden");
            }
            if(Input.GetTouch(0).phase == TouchPhase.Moved){
                Debug.Log("touch bewegend");
            }
            if(Input.GetTouch(0).phase == TouchPhase.Canceled){
                Debug.Log("touch geannuleerd");
            }
            if(Input.GetTouch(0).phase == TouchPhase.Ended){
                Debug.Log("touch beeindigd");
            }

            if(Input.GetTouch(0).phase == TouchPhase.Began){        //enkel bij het begin van het indrukken, anders kan je met je vinger over de objecten sliden
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                Debug.DrawRay(ray.origin, ray.direction *20, Color.red);
                if (Physics.Raycast(ray, out hit, Mathf.Infinity)){   //vraagt max lengte van ray en hier zeggen we dat die infinite mag zijn. en gaat als output de hitInfo in hit steken
                    Debug.Log("Hit gameObject");
                    Destroy(hit.transform.gameObject);                  //destroy het aangeraakte object
                }
            }
        }
    }
}
