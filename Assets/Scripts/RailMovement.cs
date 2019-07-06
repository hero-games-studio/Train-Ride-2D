using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailMovement : MonoBehaviour
{
     private float speed = 4.0f;
    
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;        
    }   

    void Update()
    {
                
    }   
}