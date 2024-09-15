using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerTrigger : MonoBehaviour
{

public GameObject Bouncer;

void Start () {
		Bouncer.SetActive (false);
        //Debug.Log("Hiddend Bouncer");
	}
         public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Bouncer.SetActive (true);
            //Debug.Log("Active Bouncer");
        }
    }
}
