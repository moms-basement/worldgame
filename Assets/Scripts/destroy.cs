using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private float killTime;
    
    void Start()
    {
       Destroy(gameObject, killTime); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
