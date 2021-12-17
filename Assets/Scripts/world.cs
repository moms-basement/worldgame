using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class world : MonoBehaviour
{
    public GameObject player;

    public Animator animator;

    public float turnSpeed;
 
    void Start()
    {
        player = GameObject.Find("player");
        animator = player.GetComponent<Animator>();
    }

    void Update()
    {
       if (animator.GetBool("isRunning"))
       { 
           switch (player.transform.localScale.x)
            {
                case 1:
                    
                    if (player.GetComponent<movement>().hasDashed)
                    {     
                        //transform.Rotate(Vector3.forward, turnSpeed + 0.1f * Time.deltaTime);
                        transform.Rotate(Vector3.forward, turnSpeed);
                        
                        player.GetComponent<movement>().ResetDash();
                    }

                    else
                    {
                        transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
                    }

                    
                    break;
                
                case -1:
                    
                    if (player.GetComponent<movement>().hasDashed)
                    {
                        //transform.Rotate(Vector3.forward, -turnSpeed - 0.1f * Time.deltaTime);
                        transform.Rotate(Vector3.forward, -turnSpeed);

                        player.GetComponent<movement>().ResetDash();   
                    }

                    else
                    {
                      transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);
                    } 
                    
                    //transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);

                    break;
                default:
                    break;
            }

       }
    }
}
