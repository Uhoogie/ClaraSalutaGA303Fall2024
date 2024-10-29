using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class EnemyMovement : MonoBehaviour
{

    public NavMeshAgent Enemy;
    public GameObject player;
    public Transform playerdistance;

    void OnEnable()
    {
        Enemy = GetComponent<NavMeshAgent>();
 
    }

        void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerdistance.position);

        if (distanceToPlayer <= 3)
        {
         

        }
        else if (distanceToPlayer <= 12)
        {
        Enemy.SetDestination(player.transform.position);

        }
        else if (distanceToPlayer >= 12)
        {
         

        }

    }
}
