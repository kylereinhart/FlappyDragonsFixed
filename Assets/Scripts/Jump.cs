using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Vector2 mjumpForce;
    private Rigidbody2D _rigidbody2D;

    // Update is called once per frame
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!PauseMenu.GameIsPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
            {
                _rigidbody2D.AddForce(mjumpForce);
                GetComponent<AudioSource>().Play();
            }
            else if (Input.GetButtonDown("Fire2"))
            {
                if (PowerUp.PoweredUp)
                {
                    
                }
            }
        }
    }
}
