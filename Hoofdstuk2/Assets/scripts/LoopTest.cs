using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("before loop");
        for(int i = 0; i<5; i++){
            print("loop");
        }
        print("after loop");

        int y = 0;
        while(y <=5){
            print("while: " + y);
            y++;
        }        
        print("after while: "+ y);
        // int j = 0;
        // while(j < 1){
        //     print("while: " + j);
        // } 
    }

    // Update is called once per frame
    void Update()
    {
        print("ee");
    }
}
