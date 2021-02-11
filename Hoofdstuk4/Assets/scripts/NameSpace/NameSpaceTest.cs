using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using NielEveraerts;
using NielEveraerts.UI; //geneste namespaces apart geimporteerd worden

public class NameSpaceTest : UnityEngine.MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //UnityEngine.Rigidbody rigidbody;

        //UnityEngine.UI.Text text;

        NielEveraerts.Utilities.PrintNiel();
        Utilities.PrintNiel();

        UIStuff.DoUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 