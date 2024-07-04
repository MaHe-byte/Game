using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{   
    public int damage;
    public EnemyHealth enemyHealth;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            enemyHealth.TakeDamage(damage);
        }
    }
}


