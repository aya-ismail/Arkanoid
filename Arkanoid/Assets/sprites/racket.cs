using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
    public int speed = 150;


    void FixedUpdate()

    { //get horizantal input 
        float h = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
    
    
    
        
    }



