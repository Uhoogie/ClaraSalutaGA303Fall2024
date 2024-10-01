using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{

    public bool hasKey = false;
        private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Oh a key.");

        if (other.tag == "Player")
        {
            hasKey = true;
            Debug.Log("A Key!");
            this.gameObject.SetActive(false);

        }
    }
}
