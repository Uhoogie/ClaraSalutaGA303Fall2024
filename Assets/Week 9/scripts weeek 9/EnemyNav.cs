using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public GameObject player;
    public Transform playerdistance;
    public NavMeshAgent navAgent;

    public List<Transform> patrolPoints = new List<Transform>();
    public int patrolIndex = 0;
    void OnEnable()
    {
        Enemy = GetComponent<NavMeshAgent>();
        

        navAgent.SetDestination(patrolPoints[patrolIndex].position);
    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, playerdistance.transform.position)) 
            { 
            
            Vector3 direction = player.transform.position - this.transform.position.normalized;
            RaycastHit hit;

            if (Physics.Raycast(this.transform.position, direction, out hit, 8f))
                {
                if (hit.collider.tag == "Player");
                }
        }

        if (navAgent.remainingDistance < 0.5f)
        {
            patrolIndex++;

            if (patrolIndex >= patrolPoints.Count)
            {
                patrolIndex = 0;
            }
            navAgent.SetDestination(patrolPoints[patrolIndex].position);


        }

    }
}

