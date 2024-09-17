using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScript : MonoBehaviour
{
    public GameObject fruit1;
    public GameObject fruit2;
    public GameObject fruit3;
    public GameObject fruit4;
    public int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (tag == "Player")
        {
            Destroy(gameObject);
            counter++;
        }
    }
}
