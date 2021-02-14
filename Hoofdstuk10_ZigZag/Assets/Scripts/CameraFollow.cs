using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject ball;
    Vector3 offset;
    public float lerpRate;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        offset = ball.transform.position - transform.position;      //hiermee weet je de standaard lengtte tussen de bal en de camera
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver){
            Follow();
        }
    }

    void Follow(){
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        transform.position = Vector3.Lerp(pos, targetPos, lerpRate * Time.deltaTime);  //ga van de ene value naar de andere value in een bepaalde rate, hierdoor gaat de camera zonder te trillen volgen
    }
}
