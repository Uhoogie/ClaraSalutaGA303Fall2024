using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastChecker : MonoBehaviour
{
    public Transform cameraTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit))
            {
                Debug.Log("hit");
                Debug.DrawRay(cameraTransform.position, cameraTransform.forward);
            }
        }
    }
}
