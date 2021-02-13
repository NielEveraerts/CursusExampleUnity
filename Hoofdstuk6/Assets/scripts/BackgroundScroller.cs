using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    Material material;
    Vector2 offset;
    public float groundSpeed;
    float walkingSpeed = 10; 

    public int xVel, yVel;

    private void Awake(){
        material = GetComponent<Renderer>().material;
    }

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(xVel, yVel);
    }

    // Update is called once per frame
    void Update()
    {
        float vel = Input.GetAxis("Horizontal");
        material.mainTextureOffset += Vector2.right * vel * walkingSpeed * groundSpeed * Time.deltaTime;
    }
}
