using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickTest : MonoBehaviour
{

    public GameObject cube;


    Button greenButton;

    // Start is called before the first frame update
    void Start()
    {
        greenButton = GameObject.Find("GreenButton").GetComponent<Button>();        //ipv de button een onClick in de editor te geven gaan we in het script zelf de juiste knop zoeken
        greenButton.onClick.AddListener( () => ChangeToGreen());                    //we voegen een listener toe die checkt of de knop word ingedrukt en zo ja start de ChangeToGreen functie
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToRed(){
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    public void ChangeToGreen(){
        cube.GetComponent<Renderer>().material.color = Color.green;
    }
}
