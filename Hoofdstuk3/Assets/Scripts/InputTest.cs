using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){        //print op het moment je indrukt
            print("spacebutton pressed down");
            GetComponent<Renderer>().material.color = Color.green;
        }
        if(Input.GetKeyUp(KeyCode.Space)){          //print wanneer je de knop loslaat
            print("spacebutton pressed released");
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if(Input.GetKey(KeyCode.Space)){            //blijft printen zolang je ingedrukt houdt -> soort van while zolang je indrukt
            print("spacebutton held down");
        }

        if(Input.GetButtonDown("Jump")){            //ga naar project settings -> input -> en open axes, hierin staan predefined acties die verbonden zijn aan knoppen, met getButton kan je dus checken of de actie verbonden met de knop geactiveerd wordy
            print("jump button pressed down");
            GetComponent<Renderer>().material.color = Color.green;
        }

        //
        float xInput = Input.GetAxis("Horizontal")*speed*Time.deltaTime; //time.deltaTime zorgt ervoor dat de waarde niet frame dependant is (anders gaat het anders aanvaoelen op verschillende pc's), het gaat de waarde naar speed/seconde omvormen
        float yInput = Input.GetAxis("Vertical")*speed*Time.deltaTime;

        print(xInput);

        transform.Translate(xInput, yInput, 0);   
        Input.GetAxisRaw("Vertical");               //getAxis gaat geleidelijk van 0 naar 1, bij getAxisRaw gaat het direct van 0 naar 1 bij een input.
    }
}
