using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown(){ //werkt ook bij touchscreens

        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();   //zoek GameManager object, neem het GameManager component -> het script en roep de ScorUp funcite op
        Destroy(gameObject);
    }
}
