using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///Source:https://www.youtube.com/watch?v=52hW2y6D8sw

public class ParticleController : MonoBehaviour
{
 [SerializeField] ParticleSystem movementParticle;

 [Range(0,10)]
 [SerializeField] int occurAfterVelocity;
 
 [Range(0,0.2f)]
 [SerializeField] float dustFormationPeriod;

 [SerializeField] Rigidbody2D playerRb;
 [SerializeField] ParticleSystem fallParticle;
 [SerializeField] ParticleSystem touchParticle;

 float counter;
 bool isOnGround;


    // Update is called once per frame
    private void Update()
    {
        counter += Time.deltaTime;

        if (Mathf.Abs(playerRb.velocity.x) > occurAfterVelocity)
        {
            if (counter > dustFormationPeriod)
            {
                movementParticle.Play();
                counter = 0;
            }
        }
    }

    public void PlayTouchParticle()
    {
        touchParticle.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            fallParticle.Play();
        }
    }

    public void PlayFallParticle()
    {
        fallParticle.Play();
    }
}
