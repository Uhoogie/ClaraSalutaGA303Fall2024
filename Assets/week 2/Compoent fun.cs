using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compoentfun : MonoBehaviour
{
    // Start is called before the first frame update
    public bool kill = false;
    public int counter = 1;
    void Start()
    {
       // gameObject.SetActive(false); //this would turn off game object in scene
      //  gameObject.SetActive(true); //this would turn on game object in scene

      //  gameObject.transform.Translate(transform.position);

        
    }

    // Update is called once per frame
    void Update()
    {

        if (kill == true)
        { 
            GameObject.Find("Tiff the Ceo").SetActive(false);
        } else { 
            GameObject.Find("Tiff the Ceo").SetActive(true); 
        }


        
    }
}
