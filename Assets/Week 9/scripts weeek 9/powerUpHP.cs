using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpHP : PoweUpScript
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            health = health + healthup;

            Debug.Log("Wow I feel Healthy!");
            Destroy(gameObject);
        }
    }


}
