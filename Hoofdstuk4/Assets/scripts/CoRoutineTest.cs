using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Test()); //of
        StartCoroutine("Test"); //blijkbaar de aanbevolen manier

        //Test2();               //print test2 5 keer voordat start word geprint
        StartCoroutine("Test3"); //nu moet start print niet wachten op test
        StartCoroutine("Test4",5);  //zo kan je parameters meegeven aan de coroutine
        for (int i = 0; i < 6; i++)
        {
            print("Start");
        }
        StopCoroutine("Test3"); //stopt de CoRoutine ookal is die functie nog bezig
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Test(){
        print("CoRoutine start");
        yield return new WaitForSeconds(2f);                        //wahct 2 seconden voordat we verder gaan in de functie

        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(2f);                        //wahct 2 seconden voordat we verder gaan in de functie
        
        GetComponent<Renderer>().material.color = Color.green;
        print("CoRoutine end");

        yield return null;  //betekent dat we wachten tot de volgende frame
    }


    void Test2(){
        for (int i = 0; i < 6; i++)
        {
            print("test2()");
        }
    }

    IEnumerator Test3(){
        for (int i = 0; i < 6; i++)
        {
            print("test3()");
            yield return null;
        }
    }

        IEnumerator Test4(int times){
        for (int i = 0; i < times; i++)
        {
            print("test3()");
            yield return null;
        }
    }
}
