using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{

    public float maxTime;           //hoelang we een aanraking als swipe bekijken
    public float minSwipeDist;      //minimum lengte dat de aanraking verschuift voordfat we het als een swipe bekijken

    float startTime;
    float endTime;

    Vector3 startPos;
    Vector3 endPos;

    float swipeDist;
    float swipeTime;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){    //check if de touchfase "begonnen" is
                startTime = Time.time;              //neem huidige tijd
                startPos = touch.position;          //neem huidige pos van vinger
            }
            else if(touch.phase == TouchPhase.Ended){   //check if de touchfase "beeindigd" is
                endTime = Time.time;
                endPos = touch.position;

                swipeDist = (endPos - startPos).magnitude;  //magnitude geeft de waarde tussen 2 coordinaten terug -> hierdoor moet je zelf die berekening doen
                swipeTime = endTime - startTime;

                if(swipeTime < maxTime && swipeDist > minSwipeDist){    //enkel als de voorwaarden juist zijn gaan we het als een swipe bekijken
                    Swipe();
                }
            }
        }
    }

    void Swipe(){
        Vector2 dist = endPos - startPos;

        if(Mathf.Abs(dist.x) > Mathf.Abs(dist.y)){      //mathf.abs geeft de absolute waarde -> dus altijd positief
            Debug.Log("Horizontale swipe");

            if(dist.x > 0){                             //positief in x-as -> naar rechts geswiped
                Debug.Log("Right swipe");
            }
            else if(dist.x < 0){                        //negatief in x-as -> naar links geswiped
                Debug.Log("Left swipe");
            }
        }
        else if(Mathf.Abs(dist.x) < Mathf.Abs(dist.y)){
            Debug.Log("Verticale swipe");

            if(dist.y > 0){
                Debug.Log("Up swipe");
                player.GetComponent<PlayerJumpTest>().Jump();   //nu het gameObject als variable aan dit script is toegevoegd kunnen we via de getComponent aan het script en aan de functie (public)
            }
            else if(dist.y < 0){
                Debug.Log("Down swipe");
            }
        }
    }
}
