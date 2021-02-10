using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public float speed = 10f;

    public GameObject ball;
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

        //print(xInput);

        transform.Translate(xInput, yInput, 0);   
        Input.GetAxisRaw("Vertical");               //getAxis gaat geleidelijk van 0 naar 1, bij getAxisRaw gaat het direct van 0 naar 1 bij een input.

        // if(Input.GetButtonDown("Fire1")){
        //     print("Left Click");
        // }

        if(Input.GetMouseButtonDown(0)){           //0 = linker muisknop, 1 = rechtermuisknop, 2 = muiswiel indrukken
            print("Left Click");
            print("X: "+Input.mousePosition.x + ", Y: " + Input.mousePosition.y);   //dit is in screencoordinaten

            Vector3 pos = Input.mousePosition;          //screencoordinaten, BELANGRIJK we moeten deze aanpassen naar worldcoordinaten
            pos.z = 10f;                                //verplaats op z positie zodat heij niet in de camera gaat spawnen
            pos = Camera.main.ScreenToWorldPoint(pos);  //hier converteren we de screencoordinaten naar WorldCoordinaten

            Instantiate(ball , pos, Quaternion.identity);

        }

        if(Input.GetMouseButtonDown(1)){           //0 = linker muisknop, 1 = rechtermuisknop, 2 = muiswiel indrukken
            print("Right Click");
        }

        if(Input.GetMouseButtonDown(2)){           //0 = linker muisknop, 1 = rechtermuisknop, 2 = muiswiel indrukken
            print("Middle Click");
        }
    }

    void OnMouseDown(){                     //funcite die detecteert wanneer op het object word geklikt, het script moet wel in het object zitten dat je wilt verwijderen als je erop klikt, ook moet het object een collider hebben
        Destroy(gameObject);
    }
}
