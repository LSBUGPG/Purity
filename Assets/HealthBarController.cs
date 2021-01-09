using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Image healthbar;
    public float health;
    public float startHealth;

    public void OnTakeDamage(int damage)
    {
        float v = health - damage;
        
        healthbar.fillAmount = health / startHealth;




    }



}
