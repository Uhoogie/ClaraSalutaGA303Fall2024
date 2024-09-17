using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyComb : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destroy") //had to use the tag to make the collision kill player assigned it to cube
        {
            Destroy(gameObject); //what ever game object it's on get's destroyed
        }
    }
}
