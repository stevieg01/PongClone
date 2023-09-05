using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float xSpeed = 0; 
    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y);
    }
}
