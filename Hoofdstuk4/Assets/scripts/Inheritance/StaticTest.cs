using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{        
    public static int a = 0;
    // Start is called before the first frame update
    void Start()
    {

        Bullets bullet1 = new Bullets();
        //bullet1.nOfBullets = 10;      //werkt niet
        Bullets bullet2 = new Bullets();

        //Bullets.nOfBullets = 13;    //nu dat de var van de Bullets klasse static is, gaat er altijd maar 1 instance zijn van deze var, daarbij om die aan te spreken ga je het via de klasse zelf aanspreken ipv een object van die klasse
        //Bullets.nOfBullets = 18;

        print(Bullets.nOfBullets);
        Bullets.ShowBullets();

        Input.GetButtonDown("");    //ook dit is static

        a++;                        //je moet geen constructor gebruiken als je de Start functie van Unity hebt, zo kan je dan voor elk gameObject a++ doen
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Bullets{   	                        //een klasse kan ook volledig static zijn, dan moet alles binnen deze klasse static gemaakt worden.
    public static int nOfBullets = 0;               //best practice om zo weinig mogelijk static vars te gebruiken aangezien ze constant geheugen verbruiken en net zoals bij games moet je die zo laag mogelijk houden

    public Bullets(){                               //hiermee kan je tellen hoeveel instances van de Bullets klasse er zijn aangezien elke keer er een object gemaakt word,  de constructor zegt dat de var +1 krijgt
        nOfBullets++;       
    }

    public static void ShowBullets(){               //deze functie verwacht wel dat de variables die hij gebruikt ook static zijn!
        Debug.Log("No of Bullets: " + nOfBullets);
    }
}