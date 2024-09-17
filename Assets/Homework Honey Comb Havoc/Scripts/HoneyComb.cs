using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyComb : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touch");
       
        if (other.tag == "Destroy")
         {
           Debug.Log("BEES!");
           Destroy(this.transform.parent.gameObject); 
          }
    }
}
