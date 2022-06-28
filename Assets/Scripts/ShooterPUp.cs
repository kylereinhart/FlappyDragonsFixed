using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterPUp : MonoBehaviour
{
    public GameObject mPoweredPrefab;
    public int powertype = 5;
    
    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.GameIsPaused)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                if (PowerUp.PoweredUp)
                {
                    //bloom
                    var translatep = transform.position;
                    translatep.x += (float) 1.5;
                    var projectilep = GameObject.Instantiate(
                        mPoweredPrefab,
                        translatep,
                        mPoweredPrefab.transform.rotation);
                    PowerUp.PoweredUp = false;
                }
            }
        }
    }
}
