using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiationTest : MonoBehaviour
{
    public GameObject spawnedPrefab;
    void Start()
    {
        
        //Instantiate(spawnedPrefab); //spawns prefab

       // Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation); //this spawns it at objects position and rotation

        GameObject jeff = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);

        jeff.GetComponent<Light>().color = Color.blue;

    }



    void Update()
    {
        
    }
}
