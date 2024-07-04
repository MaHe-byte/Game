using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

///Source: https://www.youtube.com/watch?v=vkKulG71Yzo

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

public void TakeDamage(int damage)
        {
            health -= damage;
            

            if(health <=0)
            {
                AudioManager.Instance.PlaySFX("Damage_enemy");
                Destroy(gameObject);
            }

        }
}