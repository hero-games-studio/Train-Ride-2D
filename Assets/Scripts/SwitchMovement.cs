using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMovement : MonoBehaviour
{    
    void Start()
    {
        
    }
   
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if ((collider.gameObject.name == "ball")&&(Input.GetKeyDown(KeyCode.RightArrow)))
        {            
            transform.Rotate(0, 0, -45);            
        }
        if ((collider.gameObject.name == "ball") && (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            transform.Rotate(0, 0, 45);
        }
    }
}