using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastChecker : MonoBehaviour
{
    public Transform cameraTransform;
    public int moveAmount = 10; //for the move later

    public KeyScript KeycheckRed;
    public KeyScript KeycheckYellow;
    public KeyScript KeycheckGreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            RaycastHit hit;
            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit)) //ray cast based off of the camera
            {
                if (hit.collider.CompareTag("Door")) //check for door tag
                {
                  DoorScript doorScript = hit.collider.GetComponent<DoorScript>(); //in game checks for script and later can use the info so I can not have a million door thingys
                  //(This is a note for future me btw since I will ref this in the future cause I will forget) I didn't do it with the keys me because I am disabling the keys and using trigger not ray casting to get them so it wouldn't work.
                 
                    {

                        if (doorScript.redDoor && KeycheckRed.gameObject.activeSelf == false) //checks the doors color and if you've collected the proper keys
                        {
                            Debug.Log("Red door is open! Yipppeee!");
                            hit.collider.transform.Translate(Vector3.up * moveAmount);
                            Destroy(KeycheckRed);
                        }

                        else if (doorScript.yellowDoor && KeycheckYellow.gameObject.activeSelf == false)
                        {
                            Debug.Log("Yellow door is open! Yahoo!");
                            hit.collider.transform.Translate(Vector3.up * moveAmount);
                            Destroy(KeycheckYellow);
                        }


                        else if (doorScript.greenDoor && KeycheckGreen.gameObject.activeSelf == false)
                        {
                            Debug.Log("Green door is open! Wooo!");
                            hit.collider.transform.Translate(Vector3.up * moveAmount);
                            Destroy(KeycheckRed);
                        }
                        else
                        {
                            Debug.Log("Door is locked... sadge :(");
                        }
                    }
                }
            }
        }
    }
}
