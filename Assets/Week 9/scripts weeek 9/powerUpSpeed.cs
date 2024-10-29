using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpeed : PoweUpScript
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            attackInterval = attackInterval - speedup;

            Debug.Log("Wow I feel Fast!");
            Destroy(gameObject);
        }
    }
}
