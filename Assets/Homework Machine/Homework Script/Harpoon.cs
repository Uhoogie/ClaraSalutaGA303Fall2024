using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harpoon : MonoBehaviour
{
    public GameObject HarpoonSpear; //this will be our objext we spawn
    public Transform HarpoonSpawnLocation;
    public float HarpoonSpeed = 1000f;

   void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject go = Instantiate(HarpoonSpear, HarpoonSpawnLocation.position, HarpoonSpawnLocation.rotation);
            go.GetComponent<Rigidbody>().AddForce(go.transform.up * HarpoonSpeed);
            Debug.Log("WHY WOULD YOU PRESS THAT???");
        }

    }
}
