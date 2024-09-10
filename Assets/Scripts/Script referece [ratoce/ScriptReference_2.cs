using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptReference_2 : MonoBehaviour
{


    public Light lightref2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //this shows its getting called
    public void heyitsworking()
    {
        Debug.Log("Dang grrrl u got it workin'");
        
    }

    public void lightrefwow()
    {
        lightref2.color = Color.blue;
        Debug.Log("Light work wow");
    }
    
}
