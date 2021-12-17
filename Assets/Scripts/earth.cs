using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class earth : MonoBehaviour
{
    public float currentHp = 20;


    private Image image;

    [SerializeField] private GameObject cover;

     
    void Start()
    {           
        Debug.Log(currentHp);

                
    }
    public void DecreaseHP()
    {   
        Instantiate(cover);

        if (currentHp == 0)
        {
            currentHp = 20;
        }
 
        this.currentHp -= 1;

        CameraShake.Shake(0.5f, 0.4f);
          
        Debug.Log($"earth is on {currentHp} hp");


        //healthbar.fillAmount = currentHp / 20;

        
        soundManager.PlaySound("explosion");
    }

    public float ReturnHP(){
        return this.currentHp;
    }
}
