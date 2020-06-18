using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonstopEnemy : Enemy
{
    //Private variables
    //----------------------
    private Rigidbody2D rb;

    private float timer;

    [SerializeField]
    private Transform bulletSpawn;
    //----------------------

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = -transform.up * Speed; //Set the bullet in motion
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= (1.0f / BulletType.FiringRate)) //Firing rate is based in bullets per second
        {
            FireBullet();

            timer = 0;
        }
    }

    //Fire current ammo type
    void FireBullet()
    {
        Instantiate((GameObject)Resources.Load("Prefabs/" +BulletType.BulletName), bulletSpawn.position, transform.rotation);
    }
}