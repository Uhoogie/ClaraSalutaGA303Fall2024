using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpeed : MonoBehaviour
{
    public float Speedup; 

    private void OnTriggerEnter(Collider other)
    {
        PlayerRPG player = other.GetComponent<PlayerRPG>();
        
        if (player != null)
        {
            player.attackInterval -= Speedup;
            Debug.Log($"New Health: {player.health}, New Attack Damage: {player.attackDamage}, New Attack Interval: {player.attackInterval}");
            Debug.Log("Wow I feel Fast!");
            Destroy(gameObject);
        }
    }
}
