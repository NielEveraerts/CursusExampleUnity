using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{

    public float rotationSpeed;

    void OnMouseDrag(){
        float y = Input.GetAxis("Mouse Y") * rotationSpeed;
        float x = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.Rotate(Vector3.right, y);
        transform.Rotate(Vector3.down, x);
    }
}
