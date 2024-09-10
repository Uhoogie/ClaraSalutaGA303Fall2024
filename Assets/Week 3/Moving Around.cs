using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAround : MonoBehaviour
{

    //every object can acess transform and gameobject
    public Transform cubeteleportpos; //we use transform for the position of the object
   // public Transform cameratransform;
    public float speed = 5f;

    void Start()
    {
        this.transform.Translate(Vector3.right);
    }

    // Update is called once per frame
    void Update()
    {
        //first way to move it whic is it moving riht every second
        //this.transform.Translate(Vector3.right * Time.deltaTime); //makes the object move right every second
        // makes object move right with translate, time.deltatime make it so it's every second

        //second way to move it by teleportationto cords
        //this.transform.position = Vector3.one;

        //this adds 1,1,1 to the position
        //this.transform.position += Vector3.one * Time.deltaTime;

        //to move it to very spefici cords
        //this.transform.position = new Vector3(-5, 5, 0);

        //this teleports it to where cubetelportpos is so that it takes its cords
        //this.transform.position = cubeteleportpos.position;

        if (Input.GetKeyDown(KeyCode.H))
        {

            this.transform.position = Camera.main.transform.position; //acesses main camera based off of the tags
          //  this.transform.position = cameratransform.position; //puts to the camera position
          //  this.transform.position += this.transform.forward; //makes it local forward +1
          //  this.transform.position += Vector3.forward; //makes it unviversal forward +1
            this.transform.position += this.transform.forward * speed; //if we wanna move it forward by more than 1 make a float variable

        }
    }
}
