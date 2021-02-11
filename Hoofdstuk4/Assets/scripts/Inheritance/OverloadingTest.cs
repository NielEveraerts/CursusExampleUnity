using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverloadingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fun fun = new Fun();
        fun.printInt(1);
        fun.printFloat(1.2f);
        fun.printString("print");

        //overloaded
        fun.Print(2);       
        fun.Print(2.1f);       
        fun.Print("test");   
        fun.Print(2,1);       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Fun{
    public void printInt(int i){
        Debug.Log(i);
    }
    public void printFloat(float i){
        Debug.Log(i);
    }
    public void printString(string i){
        Debug.Log(i);
    }

    //overloading: functies met dezelfde naam maar andere parameters
    public void Print(int i){
        Debug.Log("Print(int)");
    }
    public void Print(float i){
        Debug.Log("Print(float)");
    }
    public void Print(string i){
        Debug.Log("Print(string)");
    }

    public void Print(int i, int j){
        Debug.Log("Print(int i, int j)");
    }
}
