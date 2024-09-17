using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScript : MonoBehaviour
{
    public ScoreManager counter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Fruit!");
            Destroy(this.gameObject);
           // counter++;
        }
    }
}
