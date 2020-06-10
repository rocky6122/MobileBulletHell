using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicBullet : Bullet
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = transform.up * Speed; //Set the bullet in motion

        //Destroy it after duration.
        Destroy(gameObject, duration);
    }
}
