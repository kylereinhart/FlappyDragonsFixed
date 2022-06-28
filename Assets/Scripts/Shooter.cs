using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject mprojecectilePrefab;
    //public GameObject mPoweredPrefab;
    private float cooldown = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown <= 0)
        {
            if (!PauseMenu.GameIsPaused) 
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    cooldown = .6f;
                    var translate = transform.position;
                    translate.x += (float)1.5;
                    var projectile = GameObject.Instantiate(
                        mprojecectilePrefab, 
                        translate,
                        mprojecectilePrefab.transform.rotation);
                }
                
                
            }
        }
        
        else
        {
            cooldown -= Time.deltaTime;
        }

    }
}
