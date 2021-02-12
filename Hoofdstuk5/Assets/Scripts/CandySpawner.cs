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

        float rndX = Random.Range(-maxX, maxX);
        Vector3 rndPos = new Vector3(rndX, transform.position.y, transform.position.z); //neem de random xPos en neem de y en z van het gameObject
        
        Instantiate(candies[rnd], rndPos, transform.rotation);  //wat instantieren, waar, en in welke rotatie
    }
}
