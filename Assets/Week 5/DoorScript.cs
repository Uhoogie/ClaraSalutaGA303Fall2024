using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public KeyScript Keycheck;
    public GameObject Door;

    

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Oh a Door.");
        if (other.tag == "Player")
        {
            if (Keycheck == false)
            {
                Debug.Log("Door is Locked");
            }

            else
            {
                Debug.Log("Door is Open");
                Door.SetActive(false);
            }
        }
    }
}
