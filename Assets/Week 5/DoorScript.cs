using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    //doors not working cause it's not on the object and triggers needs to be changed
    public KeyScript Keycheck;
    public GameObject Door;
    public ObjectColors color;

     public bool redDoor = false;
    public bool greenDoor = false;
    public bool yellowDoor = false;



    private void Start()
    {
        switch (color)
        {
            case ObjectColors.Red:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                redDoor = true;
                break;

            case ObjectColors.Yellow:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                yellowDoor = true;
                break;

            case ObjectColors.Green:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                greenDoor = true;
                break;
        }
    }
}