using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed = 0.2f;
    [SerializeField] private float maxSpeed = 2f;
    [SerializeField] private float acceleration = 0.3f;
 
    void Start() 
    {
        // makes sure that when the earth rotates the meteros rotate with it 
       //transform.SetParent(target.transform);
       
    }
    
    void Update()
    {
       if (speed < maxSpeed)
       {
          speed += acceleration * Time.deltaTime; 
       }

       transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime); 
    }

    public void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.name == "earth")
        {
           Debug.Log("earth was hit");
           
           target.GetComponent<earth>().DecreaseHP();            
           this.SelfDestruct(); 
        }
    }

    public void SelfDestruct()
    {
        GameObject earth = GameObject.Find("earth");
        
        //Instantiate(brokenPrefab, transform.position, Quaternion.identity, earth.transform);
        // uh no, 
        
        Destroy(gameObject);
    }

    

        
}
