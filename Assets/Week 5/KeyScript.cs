using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public ObjectColors color;

    private void Start()
    {
        switch (color)
        {
            case ObjectColors.Red:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                break;

            case ObjectColors.Yellow:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;

            case ObjectColors.Green:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
        }
    }
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
