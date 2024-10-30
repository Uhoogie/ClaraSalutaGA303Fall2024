using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpAttack : MonoBehaviour
{
    public int attackDamageUp; 

    private void OnTriggerEnter(Collider other)
    {
        PlayerRPG player = other.GetComponent<PlayerRPG>();
        
        if (player != null)
        {
            player.attackDamage += attackDamageUp;
            Debug.Log($"New Health: {player.health}, New Attack Damage: {player.attackDamage}, New Attack Interval: {player.attackInterval}");
            Debug.Log("Wow I feel fierce!");
            Destroy(gameObject);
        }
    }
}
