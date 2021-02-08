using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{

    int[] numbers = new int[10]; //10 betekent dat het max aantal items in deze aary maar 10 mag zijn (length = 10)
    public int[] rollNumber;
    string[] names = new string[5];

    public GameObject[] objects;

    public Color[] colors;  //Color is een object van UnityEngine 

    // Start is called before the first frame update
    void Start()
    {
        print(rollNumber[2]);
        print(rollNumber.Length);


        names[0] = "Niel";
        names[1] = "Sam";
        names[2] = "Mark";
        names[3] = "Zalm";
        names[4] = "Mohammed";

        print(names[2]);

        //Destroy(objects[1], 1f);
        objects[0].GetComponent<Renderer>().material.color = colors[0];
        objects[1].GetComponent<Renderer>().material.color = colors[1];
        objects[2].GetComponent<Renderer>().material.color = colors[2];
        objects[3].GetComponent<Renderer>().material.color = colors[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
