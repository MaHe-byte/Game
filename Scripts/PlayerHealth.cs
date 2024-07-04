using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
///Source: https://www.youtube.com/watch?v=KF3EVjOhN4c&list=PLSR2vNOypvs72jRSvOEWv448Tle9nDw1Z

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public TextMeshProUGUI healthText;
    public ParticleController pc;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

public void TakeDamage(int damage)
        {
            health -= damage;
            AudioManager.Instance.PlaySFX("Damage");
            pc.PlayTouchParticle();
            

            if(health <=0)
            {
                SceneManager.LoadScene(1);
            }

        }

    void Update()
    {
        healthText.text = "Health: "+health.ToString();
        
    }
}