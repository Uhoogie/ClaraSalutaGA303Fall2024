using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    
      public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           light1.color = Color.red;
           light2.color = Color.yellow;
           light4.color = Color.green;
           light3.color = Color.blue;
           Debug.Log("Great now the warning lights are on...");
        }
    }
}
