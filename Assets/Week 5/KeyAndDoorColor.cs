using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectColors
{
    Red,
    Yellow,
    Green
}
public class KeyAndDoorColor : MonoBehaviour
{
    
   


    void Start()
    {

        var ColorManager = ObjectColors.Red;
        switch (ColorManager)
        { 
            case ObjectColors.Red:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red; 
                break;

            case ObjectColors.Yellow:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;

            case ObjectColors.Green:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                break;

        }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
