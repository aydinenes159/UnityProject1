using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class PropellerS : MonoBehaviour
{
    public float rotationSpeed = 250f;
    
    void Update()
    {
      
        
        transform.Rotate(UnityEngine.Vector3.forward, rotationSpeed * Time.deltaTime);
        
    }
}
