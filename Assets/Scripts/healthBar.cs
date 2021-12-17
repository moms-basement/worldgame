using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    
    public Slider slider;
    private float value;

    public void SetHealth(float health){
        slider.maxValue = 20f;
        slider.minValue = 0f;

        slider.value = health;
        value = health; 
                
        Debug.Log($"{slider.value}");
    }

}
