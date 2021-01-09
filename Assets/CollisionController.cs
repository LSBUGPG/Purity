using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public HealthBarController healthBar;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (healthBar)
            {
                healthBar.OnTakeDamage(10);
            }
        }
    }

}
