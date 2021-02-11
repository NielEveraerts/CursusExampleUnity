using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    private int point;
    private int lives;
    private string readOnly;

    public int Point{           //property altijd startend met hoofdletter
        get{
            return point;
        }
        set{
            if( value > 0 && value < 10 ){
                point = value;
            }
            PrintPoint();
        }
    }

    public int Lives { get; set; }
    public string ReadOnly{ get; }
    void PrintPoint(){
        Debug.Log(point);
    }
}
