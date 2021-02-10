using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
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
    }
}
