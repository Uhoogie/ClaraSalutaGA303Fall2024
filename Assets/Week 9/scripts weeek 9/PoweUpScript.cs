using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUpScript : PlayerRPG
{
    public int healthup;
    public int attackup;
    public float speedup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            health = health + healthup;
            attackDamage = attackDamage + attackup;
            attackInterval = attackInterval - speedup;

            Debug.Log("Wow I feel strong!");
            Destroy(gameObject);
        }
    }
}
