using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
   
    public float xSpeed = 0; // variable for x movement
    public float ySpeed = 0; // variable for y movement 

    private float xBorder = 4.5f; // variable for verticle border of the game 
    private float yBorder = 7.5f; // variable for border of the game


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f; // declare value for horizontal speed
        ySpeed = 0.0125f; // declare value for vertical speed
    }

    // Update is called once per frame
    void Update()
    {
        // horizontal movement
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); // move right

        if (transform.position.x >= xBorder)
        {
            xSpeed = -xSpeed; // to make it go left
        }

        if (transform.position.x <= -xBorder)
        {
            xSpeed *= -1;
        }



        //verticle movement
        transform.position = new Vector 2(transform.position.x, transform.position.y + ySpeed); // move up
        if (transform.position.y >= yBorder)
        {
            ySpeed *= -1;
        }
        if (transform.position.y <= -yBorder)
        {
            ySpeed *= -1;
        }
    }

}

   


