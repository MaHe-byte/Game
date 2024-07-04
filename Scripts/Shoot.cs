using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;
public class Shoot : MonoBehaviour

///Source: https://www.youtube.com/watch?v=vkKulG71Yzo
{
    public Transform shootingPoint;
    public GameObject bullet;
    public AudioSource shootingSound;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown ("Fire1"))
        {   
            AudioManager.Instance.PlaySFX("Shoot");
            Instantiate(bullet, shootingPoint.position, transform.rotation);
        }
    }

}
