using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Transform camTrans;
    
    public float shakeTime;
    public float shakeRange;

    Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        camTrans = this.transform;  //als het script niet in de camera zit: Camera.main.transform
        originalPos = camTrans.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            StartCoroutine("ShakeCamera");
        }
    }

    IEnumerator ShakeCamera(){
        float elapsedTime = 0;
        //waarbij de Z-as ook word veranderd
        while(elapsedTime < shakeTime){
            camTrans.position = originalPos + Random.insideUnitSphere * shakeRange;         //maakt een sphere en geeft een random waarde binnen deze sphere 
            elapsedTime += Time.deltaTime;                                                  //time.deltaTime is tijd per frame
            yield return null;
        }

        //waarbij de Z-as niet word veranderd => beter voor 2D dan 3D
        // while(elapsedTime < shakeTime){
        //     Vector3 pos = originalPos + Random.insideUnitSphere * shakeRange;
        //     pos.z = originalPos.z;
        //     camTrans.position = pos;

        //     elapsedTime += Time.deltaTime;
        //     yield return null;
        // }

        camTrans.position = originalPos;        //reseet camera terug naar originele positie
    }
}
