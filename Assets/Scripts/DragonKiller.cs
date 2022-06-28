using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5.8)
        {
            
            SceneManager.LoadScene(2);
            
        }

        if (transform.position.y < -5.8)
        {
            
            SceneManager.LoadScene(2);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "PowerUp")
        {
            
            SceneManager.LoadScene(2);
            
        }
    }

    
}
