using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///Source:https://www.youtube.com/watch?v=K1xZ-rycYY8

public class Player_move : MonoBehaviour
{
    

    public int playerSpeed=10;
    public bool facingRight = true;
    public int playerJumpPower = 1250;
    public float moveX;
    public CoinManager cm;
    public ParticleController pc;
    public float targetTime;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        PlayerLiikkuu();

        targetTime -= Time.deltaTime;

    if (targetTime <= 0.0f)
        {
        playerSpeed = 10;
        }
        
    }

    void PlayerLiikkuu() {

        moveX = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown ("Jump")){
            if (gameObject.GetComponent<Rigidbody2D>().velocity.y == 0){
                Jump();
            }
            
        
        }

        if (moveX > 0.0F && facingRight == false) {
            FlipPlayer();
    
        }   else if (moveX < 0.0f && facingRight == true) {
            FlipPlayer();
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX*playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);


    }

    void Jump() {



        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);

    }

    void FlipPlayer () {
        facingRight =! facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.Rotate(0,180,0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {

         if(other.gameObject.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

        if(other.gameObject.CompareTag("Coin"))
        {
            AudioManager.Instance.PlaySFX("Coin");
            Destroy(other.gameObject);
            pc.PlayTouchParticle();
            cm.coinCount ++;
        }

         if(other.gameObject.CompareTag("Lava"))
        {
            
            pc.PlayFallParticle();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
        
        }

            if(other.gameObject.CompareTag("Lava2"))
        {
            
            pc.PlayFallParticle();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
        
        }

         if(other.gameObject.CompareTag("PowerUp"))
        {
            
            targetTime = 10.0f;
            playerSpeed=20;
            Destroy(other.gameObject);
            
            
        
        }

          if(other.gameObject.CompareTag("Spear"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
        
        }
        


    }



}


