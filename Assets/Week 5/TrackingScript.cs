using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingScript : MonoBehaviour
{
    public Transform player; //player object
    public int xpos; //allows me to adjust in scene cause I lazy
    public int ypos;
    public int zpos;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(xpos, ypos, zpos); //tracks player based on posistion 
    }
}

