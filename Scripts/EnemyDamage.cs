using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///Source: https://www.youtube.com/watch?v=KF3EVjOhN4c&list=PLSR2vNOypvs72jRSvOEWv448Tle9nDw1Z
public class EnemyDamage : MonoBehaviour
{   
    public int damage;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }
}


