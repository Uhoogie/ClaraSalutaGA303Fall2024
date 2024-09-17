using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyComb : MonoBehaviour
{

    public GameObject player;
   
         void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Destroy")
            {
                Debug.Log("BEES!");
                Destroy(player);
                // counter++;
            }
    }
}
