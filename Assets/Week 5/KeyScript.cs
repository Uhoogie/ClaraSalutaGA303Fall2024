using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public ObjectColors color;
     public bool redKey = false;
    public bool greenKey = false;
    public bool yellowKey = false;

    public GameObject key;

    private void Start()
    {
        switch (color)
        {
            case ObjectColors.Red:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                redKey = true;
                break;

            case ObjectColors.Yellow:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                yellowKey = true;
                break;

            case ObjectColors.Green:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                greenKey = true;
                break;
        }
    }

   
   private void OnTriggerEnter(Collider other)
    {

       // Debug.Log("Oh a key.");

        if (other.tag == "Player")
        {
           
            this.gameObject.SetActive(false);

            if (yellowKey == true)
            {
            Debug.Log("Wow yellow key!");
            }

             if (redKey == true)
            {
            Debug.Log("Wow red key!");
            }

             if (greenKey == true)
            {
            Debug.Log("Wow green key!");
            }


        }
    }
   
}

