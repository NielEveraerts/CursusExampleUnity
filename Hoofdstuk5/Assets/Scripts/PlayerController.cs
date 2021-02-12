using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool canMove = true;
    
    [SerializeField]
    float moveSpeed, maxPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            Move();
        }
    }

    private void Move(){

        float inputX = Input.GetAxis("Horizontal");

        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)){
            transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime * 2;  //Vector3.right = Vector3(1,0,0)
        }
        else{
            transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;      //Vector3.right = Vector3(1,0,0)
        }

        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos); //met clamp kan de positie niet voorbij de meegegven waardes gaan, gaat die er voorbij wordt die gewoon de maxPositie, wat hier dus maxPos en de negatieve maxPos is
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z); //de clamped waarde gaan we dan als x-as positie gebruiken
    }
}
