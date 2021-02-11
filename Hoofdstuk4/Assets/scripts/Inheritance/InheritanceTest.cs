using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy();
        enemy.Attack();
        Dragon dragon = new Dragon();
        dragon.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
