using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    Vector3 lastPos;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        size = platform.transform.localScale.x;
        lastPos = platform.transform.position;

        for (int i = 0; i < 5; i++)
        {
            SpawnX();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
