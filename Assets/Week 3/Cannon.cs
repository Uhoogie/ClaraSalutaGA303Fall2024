using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBall; //this will be our objext we spawn
    public Transform cannonBallSpawnLocation;

    public float cannonBallSpeed = 5f;
    void Start()
    {
    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(cannonBall, cannonBallSpawnLocation.position, cannonBallSpawnLocation.rotation);

            go.GetComponent<Rigidbody>().AddForce(go.transform.forward * cannonBallSpeed);
        }

    }
}
