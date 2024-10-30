using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
 public int healthup = 20;
    public int attackup = 5;
    public float speedup = 0.2f;

    void OnTriggerEnter(Collider other)
    {
        PlayerRPG player = other.GetComponent<PlayerRPG>();
        
        if (player != null)
        {
            player.health += healthup;
            player.attackDamage += attackup;
            player.attackInterval -= speedup;

            Debug.Log($"New Health: {player.health}, New Attack Damage: {player.attackDamage}, New Attack Interval: {player.attackInterval}");
            Debug.Log("Wow, I feel strong!");
            Destroy(gameObject);
        }
    }
}