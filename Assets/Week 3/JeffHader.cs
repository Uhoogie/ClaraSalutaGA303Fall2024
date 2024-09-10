using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JeffHader : MonoBehaviour
{

    public int charismamodifer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision) //oncollision must have a collider
    {
        if (collision.gameObject.tag == "Player") //had to use the tag to make the collision kill player assigned it to cube
        {
            Destroy(gameObject); //what ever game object it's on get's destroyed
            Debug.Log("The flip gets" + (Random.Range(0,10)) + charismamodifer + "/10");
        }
    }

    private void OnCollisionExit(Collision collision) //called when it stops colliding with object
    {
        
    }

    private void OnCollisionStay(Collision collision)//called as long as object is colliding
    {
        
    }



}
