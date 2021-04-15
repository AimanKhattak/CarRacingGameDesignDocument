using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    public int speed = 2;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        // processing vertical user inputs
        float vertical_input = Input.GetAxis("Vertical");
       
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, vertical_input * speed);
        // processing Horizontal user inputs conditionally 
        // Check if car is moving
        if (vertical_input != 0)
        {
            // process Horizontal inputs of player
            float horizontal_input = Input.GetAxis("Horizontal");
            rigidbody.velocity = new Vector2(horizontal_input * speed, rigidbody.velocity.y);

        }


    }
   


}

