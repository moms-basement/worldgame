using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    public float force = 16f;

    public LayerMask targetLayers;

    KeyCode attack = new KeyCode();

    public float cooldown;
    private float nextAttackTime;

    
    // Start is called before the first frame update
    void Start()
    {
        attack = KeyCode.F;
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time > nextAttackTime) 
       {
          if (Input.GetKeyDown(attack))
          {
            Debug.Log("cooldown started");
            Attack();
            nextAttackTime = Time.time + cooldown;  
          }   
       } 
    }

    void Attack()
    {
        animator.SetTrigger("attack");
        
        Collider2D[] hitTargets = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, targetLayers);
        
        foreach (Collider2D target in hitTargets)
        {
            target.GetComponent<meteor>().SelfDestruct();
            Debug.Log("Hit meteor");


            Vector2 direction = (target.transform.position - attackPoint.position).normalized;
            Vector2 push = direction * force;

            Rigidbody2D rigidbody;

            rigidbody = target.GetComponent<Rigidbody2D>();
            
            rigidbody.AddForce(push, ForceMode2D.Impulse);

            soundManager.PlaySound("explode");  
        }

    }

    void OnDrawGizmosSelected() 
    {
        if (attackPoint == null)
        {
          return;   
        }
        
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);    
    }
}
