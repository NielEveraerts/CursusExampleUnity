using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public GameObject diamond;
    Vector3 lastPos;
    float size;

    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        size = platform.transform.localScale.x;
        lastPos = platform.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.gameOver){
            CancelInvoke("SpawnPlatforms");
        }
    }

    public void StartSpawning(){
        InvokeRepeating("SpawnPlatforms", 0f, 0.15f);
    }

    void SpawnPlatforms(){
        int rnd = Random.Range(0,2);
        if(rnd == 0){
            SpawnX();
        }else{
            SpawnZ();
        }
    }

    void SpawnX(){
        Vector3 tempPos = lastPos;
        tempPos.x += size;

        Instantiate(platform, tempPos, Quaternion.identity);
        lastPos = tempPos;

        //spawn diamond
        int rnd = Random.Range(0,4);
        if(rnd < 1){
            Instantiate(diamond, new Vector3(tempPos.x, tempPos.y+1.5f, tempPos.z), diamond.transform.rotation);   //nu gaan we wel een andere rotation geven dan Quaternion.Identity
        }
    }

    void SpawnZ(){
        Vector3 tempPos = lastPos;
        tempPos.z += size;

        Instantiate(platform, tempPos, Quaternion.identity);
        lastPos = tempPos;

        //spawn diamond
        int rnd = Random.Range(0,4);
        if(rnd < 1){
            Instantiate(diamond, new Vector3(tempPos.x, tempPos.y+1.5f, tempPos.z), diamond.transform.rotation); 
        }
    }
}
