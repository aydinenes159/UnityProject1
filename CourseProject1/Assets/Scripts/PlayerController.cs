using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float speed = 5.0f; 
    private float turnSpeed = 25.0f;
    
    
    private float horizontalInput;
    private float forwardInput;



    void Start()
    {
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput));
        transform.Rotate(Vector3.up,turnSpeed *horizontalInput * Time.deltaTime);
        
        
        
        // transform.Translate(Vector3.right * (Time.deltaTime * turnSpeed * horizontalInput));
        // transform.Translate(0,0,1);
    }
}
