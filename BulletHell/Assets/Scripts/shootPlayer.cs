using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPlayer : MonoBehaviour
{
    //public variables
    //--------------------
    public Transform bulletSpawn;
    public Bullet[] bulletTypes;
    //--------------------

    //private variables
    //--------------------
    int currentBulletType;
    float timer;
    //--------------------

    // Start is called before the first frame update
    void Start()
    {
        currentBulletType = 0; //always start with basic bullet
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= (1.0f / bulletTypes[currentBulletType].FiringRate)) //Firing rate is based in bullets per second
        {
            FireBullet();

            timer = 0;
        }
    }

    //Fire current ammo type
    void FireBullet()
    {

        Instantiate((GameObject)Resources.Load("Prefabs/" + bulletTypes[currentBulletType].BulletName), bulletSpawn.position, transform.rotation);
    }

    //Switch ammo type
    void SetCurrentBulletType(int value)
    {
        currentBulletType = value;
    }
}