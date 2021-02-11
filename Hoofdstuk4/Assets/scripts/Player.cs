using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Score score = new Score();
        score.Point = 5;            //setter word automatisch geactiveerd

        score.Lives = 5;
        Debug.Log(score.Lives);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
