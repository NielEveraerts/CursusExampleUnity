using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    // Start is called before the first frame update
    public int  power = 0; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (power)
        {
            case 1:
                print("Beginner");
                break;
            case 2:
                print("Intermediate");
                break;
            case 3:
                print("Advanced");
                break;
            default:
                print("Not a player");
                break;
        }
    }
}
