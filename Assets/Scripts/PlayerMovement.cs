using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Declaring variables
    private Rigidbody2D rb;// makes rigidbody variable
    public float thrust = 10.0f;// sets acceleration, can be set from inspector
    public float moveSpeed;

    void Start()//happens on first frame
    {
        rb = GetComponent<Rigidbody2D>();// assigns the Rigidbody to the rb variable
       // gameObject.transform.Translate(0.0f, 0.0f, 0.0f);// resest position to starting point.
    }

    void FixedUpdate()//happens every frame
    {
        //if (Input.GetKeyDown(KeyCode.RightArrow))// hold right arrow to go right
        //{
        //    Debug.Log("right arrow is down");//testing input
        //    Vector3 newVelocity = new Vector3(1, rb.velocity.y, 0);
        //    rb.velocity = newVelocity;
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
        //}
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0));
    }
}
