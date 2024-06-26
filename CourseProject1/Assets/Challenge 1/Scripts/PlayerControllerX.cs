﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    // public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
  
      void FixedUpdate()
      {
          // get the user's vertical input
          //verticalInput = Input.GetAxis("Vertical");

          // move the plane forward at a constant rate
          transform.Translate(Vector3.forward * speed * Time.deltaTime);

          // tilt the plane up/down based on up/down arrow keys
          if (Input.GetKey(KeyCode.W)) 
          {
              transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
          }
          if (Input.GetKey(KeyCode.S))
          {
              transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
          }

      } 
   
  
    
}
