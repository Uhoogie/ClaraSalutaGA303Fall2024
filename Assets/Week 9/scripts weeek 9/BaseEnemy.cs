using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public float health = 100f; //health
    public float speed = 3f; // speed
    public float attackDamage = 0f; //attack damage
    public float attackDistance = 5f; //range
    public Transform playerdistance;

    private float timer = 0f;
    public AudioSource audioSource;

    [SerializeField] protected float attackInterval = 1f;

    private PlayerRPG player;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerRPG>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerdistance.position);

        if (distanceToPlayer <= attackDistance)
        {
            Debug.Log("Player is in range");
            timer += Time.deltaTime;

            if (timer >= attackInterval)
            {
                Attack();
                audioSource.Play();
                timer = 0f;
            }
        }
        
        else
        { Debug.Log("Player is out of range"); }
    }
    

protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);
    }

    public virtual void Move()
    {
        
    }

    public virtual void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0f)
        {

            Debug.Log("You killed it!");
            Destroy(this.gameObject);
        }

     }
    
}
