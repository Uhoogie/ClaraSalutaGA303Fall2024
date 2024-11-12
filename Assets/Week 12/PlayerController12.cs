using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("jump");
    }
    private void OnMove(InputAction.CallbackContext context)
    {

        if (context.performed == true) 
        {
            Debug.Log("Button pressed");
        }
        if (context.canceled == true)
        {
            Debug.Log("Button not pressed");
        }
        Vector2 moveDirection = context.ReadValue<Vector2>();


        transform.position += new Vector3(moveDirection.x, 0f, moveDirection.y);
    }

}
