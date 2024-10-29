using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRPG : MonoBehaviour
{
    public float health = 100f;
    public float attackDamage = 5f;
    public float attackInterval = 1f;

    private float timer;
    private bool isAttackReady = true;

    public Text healthTrackerText;

    public Image attackReadyImage;

    public float rangedAttackDamage = 3f;
    public int RangedAmmo = 3;
    public int rangedProjectileForce = 1000;
    public GameObject rangedProjectilePrefab;
    public Transform projectilespawnposision;

    public bool isattackDamageBoosted = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthTracker();

        if (isAttackReady == false)
        {
            timer += Time.deltaTime;

            if (timer >= attackInterval)
            {
                isAttackReady = true;
                attackReadyImage.gameObject.SetActive(isAttackReady);
                timer = 0f;
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            if (isAttackReady == true)
            {
                RaycastHit hit;

                if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 3f))
                {
                    BaseEnemy enemy = hit.collider.GetComponent<BaseEnemy>();

                    if (enemy != null)
                    {
                        Attack(enemy);
                    }
                }
            }
        }

        if (Input.GetMouseButtonUp(1)) {
            rangedAttack();

        }
    }

        public void Attack(BaseEnemy enemy)
        {
        float totalDamage = attackDamage;

        if (isattackDamageBoosted == true)
        {
            totalDamage *= 1.1f;

        }

        enemy.TakeDamage(attackDamage);
            isAttackReady = false;
            attackReadyImage.gameObject.SetActive(isAttackReady);
        }

        public void TakeDamage(float damage)
        {
            health -= damage;

            if (health <= 0)
            {
                Debug.Log("YOU DIED");
            }
        }

        public void healthTracker()
        {
            healthTrackerText.text = "HP: " + health;
        }

        public void rangedAttack()
        {
            if (RangedAmmo > 0) {
                GameObject go = Instantiate(rangedProjectilePrefab, projectilespawnposision.position, projectilespawnposision.rotation);
                go.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * rangedProjectileForce);

            RangedAmmo--;
            Destroy(go, .75f);
            }
        }

    private IEnumerator waitAndRemoveAttackDamageBuff() 
    {
        yield return new WaitForSeconds(10f);
        isattackDamageBoosted = false;
    }
        
  
    } 


