using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
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
        }
    }
}
