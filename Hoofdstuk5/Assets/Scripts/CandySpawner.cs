using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float maxX;   

    public GameObject[] candies;  
    // Start is called before the first frame update
    void Start()
    {
        SpawnCandy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy(){
        int rnd = Random.Range(0, candies.Length);

        Instantiate(candies[rnd], transform.position, transform.rotation);  //wat instantieren, waar, en in welke rotatie
    }
}
