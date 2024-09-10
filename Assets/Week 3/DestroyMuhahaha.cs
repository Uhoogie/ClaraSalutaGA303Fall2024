using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DestroyMuhahaha : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destroy") //had to use the tag to make the collision kill player assigned it to cube
        {
            Destroy(gameObject); //what ever game object it's on get's destroyed
        } 
}
}
