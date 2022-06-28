using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float mSpeed = 1;
    private Enemy mEnemy;
    private PowerUp mPowerUp;
    
    private void Awake()
    {
        mEnemy = GetComponent<Enemy>();
        mPowerUp = GetComponent<PowerUp>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.left * Time.deltaTime * mSpeed, Space.World);

        if (GetType() == typeof(PowerUp))
        {
            if (transform.position.x < -11.4)
            {
                transform.position += Vector3.right * 720;
                if (!PowerUp.PoweredUp)
                {
                    mPowerUp?.Respawn();
                }
            }
        }
        else
        {
            if (transform.position.x < -11.4)
            {
                transform.position += Vector3.right * 24;
                ShowRandomSprite();
                mEnemy?.Respawn();
            }
        }
        
    }

    private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;
        
        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;
            
            child.gameObject.SetActive(shouldShow); // activates if the child is the random int
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
