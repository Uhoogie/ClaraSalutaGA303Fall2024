using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpHP : MonoBehaviour
{
    public int healthUp; 

    private void OnTriggerEnter(Collider other)
    {
        PlayerRPG player = other.GetComponent<PlayerRPG>();
        
        if (player != null)
        {
            player.health += healthUp;
            Debug.Log($"New Health: {player.health}, New Attack Damage: {player.attackDamage}, New Attack Interval: {player.attackInterval}");
            Debug.Log("Wow, I feel healthy!");
            Destroy(gameObject); 
        }
    }
}