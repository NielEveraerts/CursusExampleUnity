using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    public int minZoom2D, maxZoom2D;
    public int zoomSpeed2D;

    public int minZoom3D, maxZoom3D;
    public int zoomSpeed3D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //2D camera
        if(Camera.main.orthographic){
            if( Input.GetAxis("Mouse ScrollWheel") > 0){
                //ZoomIn
                Camera.main.orthographicSize-= zoomSpeed2D * Time.deltaTime;
            }
            if( Input.GetAxis("Mouse ScrollWheel") < 0){
                //Zoom Out                
                Camera.main.orthographicSize+= zoomSpeed2D * Time.deltaTime;
            }

            //ervoor zorgen dat de zoom niet te klein of groot kan worden
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom2D, maxZoom2D);
        }
        //else -> 3D
        else{
            if( Input.GetAxis("Mouse ScrollWheel") > 0){
                //ZoomIn
                Camera.main.fieldOfView-= zoomSpeed3D * Time.deltaTime;
            }
            if( Input.GetAxis("Mouse ScrollWheel") < 0){
                //Zoom Out                
                Camera.main.fieldOfView+= zoomSpeed3D * Time.deltaTime;
            }

            //ervoor zorgen dat de zoom niet te klein of groot kan worden
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom3D, maxZoom3D);
        }
    }
}
