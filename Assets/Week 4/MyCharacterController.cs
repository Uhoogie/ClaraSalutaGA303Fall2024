using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{

    public CharacterController controller; //gets the player controller component
    public Vector3 playerVelocity; //sees how fast the player is 
    public bool groundedPlayer; //makes it s  you can see if the players on it's ground or not so if the player isn't they can infinte jump
    public float playerSpeed = 5.0f;
    public float jumpHeight = 1.0f;
    public float gravityValue = -9.18f; //uses gravity with the jump so the player doesn't go crazy
    

    void Start()
    {
        controller = GetComponent<CharacterController>(); //get's the character controller component at the start
    }


    void Update()
    {
        movementEffects();
        movementInputs();

    }

    void movementEffects()
    {

        //running
        if (Input.GetButton("Run"))
        {
            playerSpeed = 10.0f;
        }

        else
        {
            playerSpeed = 5.0f;
        }

    }

    void movementInputs() 
    {

        groundedPlayer = controller.isGrounded;  //means that if the bool grounded player is true then the controller is grounded

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f; //means character is not moving
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //defining directions
        controller.Move(move * Time.deltaTime * playerSpeed); //determines how character moves like speed and slowing

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move; //moves the player
        }

        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue); //jump math and mathf.sqrt is a flloat of hypotenuse length so side * side + side * side
        }

        playerVelocity.y += gravityValue * Time.deltaTime; //allows you to fall from gravity
        controller.Move(playerVelocity * Time.deltaTime); //Gives the velocity stuff so it moves more natural
    }


}