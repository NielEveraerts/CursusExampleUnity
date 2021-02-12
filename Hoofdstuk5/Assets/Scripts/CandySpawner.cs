using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float maxX, spawnInterval;   

    public GameObject[] candies;  

    public static CandySpawner instance;

    private void Awake(){                   //static instance van deze klasse maken, zodat we overal aan de functies van deze klasse kunnen, soort van Manager klasse
        if(instance == null){
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //SpawnCandy();
        StartSpawning();
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

    //mbv CoRoutines
    IEnumerator SpawnCandies(){  
        yield return new WaitForSeconds(2f);

        while(true){
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);
        }
    }


    public void StartSpawning(){
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawning(){
        StopCoroutine("SpawnCandies");
    }

    //maar zou ook gaan met InvokeRepeating
    //InvokeRepeating("SpawnCandy", 2f, spawnInterval);
    //CancelInvoke("SpawnCandy");
}
