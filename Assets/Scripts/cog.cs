using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cog : MonoBehaviour
{
    public float turnSpeed;
    
    void Update()
    {
        
        transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }
}
