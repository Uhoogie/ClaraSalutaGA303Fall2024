using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptReference_1 : MonoBehaviour
{
    // Start is called before the first frame update

    //if we want to reference a component
    public Light lightref;
    //put it o a blank object and put script on it so you can select a light which will be messed with

    //to reference a script put the other script on a object to refence it think og that empty compenten
    public ScriptReference_2 scriptReference2;
    //now you can drag the object with the script onto the other object that has this script

    void Start()
    {
        lightref.color = Color.red;
        scriptReference2.heyitsworking(); //calls upon other script
        scriptReference2.lightrefwow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
