using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    Vector3 lastPos;
    float size;

    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        size = platform.transform.localScale.x;
        lastPos = platform.transform.position;

        InvokeRepeating("SpawnPlatforms", 2f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver){
            CancelInvoke("SpawnPlatforms");
        }
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
    }

    void SpawnZ(){
        Vector3 tempPos = lastPos;
        tempPos.z += size;

        Instantiate(platform, tempPos, Quaternion.identity);
        lastPos = tempPos;
    }
}
