using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private Vector2 mStartingVelocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = mStartingVelocity;
        Destroy(gameObject, 3);
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        var enemy = collision.collider.GetComponent<Enemy>();
        if (this.gameObject.name == "PowerUpShot(Clone)")
        { 
            gameObject.GetComponentInChildren<Transform>().position = gameObject.transform.position; 
            gameObject.GetComponentInChildren<CircleCollider2D>().enabled = true; 
            PowerUp.mCircle = gameObject.GetComponentInChildren<CircleCollider2D>(); 
            PowerUp.Bloom(); 
        }
        enemy?.Die();
        
        Destroy(gameObject);
    }
}