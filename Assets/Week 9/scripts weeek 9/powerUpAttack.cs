using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpAttack : PoweUpScript
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            attackDamage = attackDamage + attackup;

            Debug.Log("Wow I feel fierce!");
            Destroy(gameObject);
        }
    }
}
