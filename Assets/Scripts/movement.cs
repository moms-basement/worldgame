using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator animator = new Animator();
    public bool hasDashed = false;
    
    // public so other obj can read this
    
    KeyCode left = new KeyCode();
    KeyCode right = new KeyCode();
    KeyCode dash = new KeyCode();
    
    
    void Start()
    {
        left = KeyCode.A;
        right = KeyCode.D;
        dash = KeyCode.Space;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 charScale = transform.localScale;

        if (isMoving(charScale))
        {
            Debug.Log("Player is moving");
        }    
    }

    private bool isAttacking()
    {
        return false;
    }

    private bool isMoving(Vector3 vector3)
    {
        // left or right keys
        if (Input.GetKey(left) || Input.GetKey(right))
        {
            animator.SetBool("isRunning", true);
            
            if (Input.GetKey(left))
            {
                vector3.x = -1; // flip the character to the left 
            }

            else if(Input.GetKey(right))
            {
                vector3.x = 1;
            }

            if (Input.GetKeyUp(dash))
            {
                hasDashed = true;
            }

            transform.localScale = vector3;

            return true; // yes the char is moving
        }

        else 
        {
            animator.SetBool("isRunning", false);

            return false;
        }
    }

    public void ResetDash()
    {
        if (hasDashed == true)
        {
           hasDashed = false;   
        }
    }

}

