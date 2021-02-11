using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]       //hiermee als we die component proberen te verwijderen van het gameObject, gaat Unity een error geven en ons dat niet toelaten die te verwijderen
public class AttributesTest : MonoBehaviour
{   
    [SerializeField]        //hiermee kan de var dat private is, toch in de Unity Editor aangepast worden -> veiliger want de var is niet meer public
    private int speed;

    [HideInInspector]       //hiermee is de var wel public zodat scripts aan deze var kunnen, maar in de inspector is deze niet zichtbaar/aanpasbaar
    public int speed2;

    [Range(0,20)]           //hiermee krijg je in de editor een slider ipv een input, handig tijdens testen
    public int speed3;


    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed3*Time.deltaTime,0,0);

        rb.isKinematic = false;
    }
}
