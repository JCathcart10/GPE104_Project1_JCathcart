using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Declaring variables
    private Rigidbody2D rb;// makes rigidbody variable
    public bool canMove;// bool to show that object can move; starts as true
    public float speed = 1.0f;

    void Start()//happens on first frame
    {
        rb = GetComponent<Rigidbody2D>();// assigns the Rigidbody to the rb variable
        
       // gameObject.transform.Translate(0.0f, 0.0f, 0.0f);// resest position to starting point.
    }

    void Update()//happens every frame
    {
        if (Input.GetButtonDown("space"))// detects when the player presses the space bar
        {
            gameObject.SetActive (false);// disables the game object
        }



        if (Input.GetButtonDown("pause"))// detects when the player presses the pause key (bound to 'p')
        {
            if (canMove == true)// checks if the canMove bool it true. if it is...
            {
                canMove = false;// ...it makes it false
            }
           else// if canMove is not true...
            {
                canMove = true;// it makes it true
            }
        }

        if (canMove == true)// checks if canMove is true
        {
            if (Input.GetButton("shift"))// detects when the shift key is held down
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))// checks for right arrow input; triggers once per key press
                {
                    transform.Translate(1.0f, 0.0f, 0.0f);// moves 1 unit to the right
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow))// checks for left arrow input; triggers once per key press
                {
                    transform.Translate(-1.0f, 0.0f, 0.0f);// moves 1 unit to the left
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))// checks for up arrow input; triggers once per key press
                {
                    transform.Translate(0.0f, 1.0f, 0.0f);// moves 1 unit up
                }

                if (Input.GetKeyDown(KeyCode.DownArrow))// checks for down arrow input; triggers once per key press
                {
                    transform.Translate(0.0f, -1.0f, 0.0f);// moves 1 unit down
                }
            }

            else if (Input.GetButtonDown("reset"))// if the q key is pressed down...
            {
                transform.position = Vector3.zero;// the position is reset to (0,0,0)
            }

            else// if the shift or q keys are not held down
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0));
                // moves the sprite based on the the input from the arrow keys. the speed can be modified from the inspector
            }

        }
    }
}
