using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public static bool PoweredUp = false;
    private static int mBlooming = 0;

    [SerializeField] private GameObject BloomBall;
    public static CircleCollider2D mCircle;
    
    public void Despawn()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }

    public void Respawn()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }
    
    public static void Bloom()
    {
        mBlooming = 1;
        
    }

    private void Update()
    {
        if (Time.time - Time.deltaTime == 1f)
        {
            if (PoweredUp == false)
            {
                Respawn();
            }
        }

        if (mBlooming == 1 && mCircle.GetComponent<CircleCollider2D>().radius < 2.1)
        {
            mCircle.GetComponent<CircleCollider2D>().radius += Time.time - Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"I'M TRIGGERED! {collision.gameObject.name}");
        Debug.Log(collision.tag);
        if (collision.tag == "Player")
        { 
            PoweredUp = true;
            var powerball = this.gameObject.GetComponent<PowerUp>();
            powerball.Despawn();
            /*Debug.Log(message:$"Player collider active? {collision.GetComponent<Collider2D>().isActiveAndEnabled}");
            //collision.enabled.Equals(true);
            collision.GetComponent<Rigidbody2D>().isKinematic = true;
            //collision.GetComponent<Rigidbody2D>().freezeRotation = true;
            Debug.Log(message:$"Player collider active? {collision.GetComponent<Collider2D>().isActiveAndEnabled}");
            */
        }
        
        // re-enable the collider
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // do animation if collides with enemy
        // else set variable
    }
}
