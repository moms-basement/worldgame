using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{
    void Update()
    {
       // kinda trash way of doing it but it works for now
       // better to use OnBecameInvisible
       transform.position += new Vector3(-2 * Time.deltaTime, 0);

        if (transform.position.x < -17.82)
        {
            transform.position = new Vector3(17.82f, transform.position.y);
        }
    }

    
}
