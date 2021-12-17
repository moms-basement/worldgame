using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{

    [SerializeField] private float delay;
    void Start()
    {
       
       Destroy(gameObject, delay);


        //GetComponentInChildren<Rigidbody2D>().AddForce(Random.insideUnitCircle.normalized);
        
        
        //foreach (Transform child in transform)
        //{
         //   GetComponentInChildren<Rigidbody2D>().AddForce(Random.insideUnitCircle.normalized);   
        //}

        
    }

    void Update() 
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Rigidbody2D rigidbody2D;
            rigidbody2D = transform.GetChild(i).GetComponent<Rigidbody2D>();
            
            rigidbody2D.AddForce(Random.insideUnitCircle.normalized * 5);
        }

        foreach (Transform child in transform)
        {
            GetComponentInChildren<Rigidbody2D>().AddForce(Random.insideUnitCircle.normalized * 100);   
        }


    }

}
