using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //private variables
    //--------------------
    [SerializeField]
    string bulletName;

    [SerializeField]
    private int damage = 0;

    [SerializeField]
    private int firingRate = 0;

    [SerializeField]
    private int speed = 0; 
    //--------------------

    //public variables
    //--------------------
    public float duration; //How long a bullet lasts
    //--------------------

    //Getter|Setter Functions
    //------------------------------------------
    public string BulletName //name of prefab
    {
        get { return bulletName; }
        private set { bulletName = value; }
    }

    public int Damage 
    {
        get { return damage; }
        private set { damage = value; }
    }

    public int FiringRate //Bullets per second
    {
        get { return firingRate;  }
        private set { firingRate = value; } 
    }

    public int Speed //speed applied once to rigidbody on spawn
    {
        get { return speed; }
        private set { speed = value; }
    }
    //------------------------------------------

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "bullet") //TODO as of right now bullets can never collide, but in the future we might want some to collide. This would need to be changed for that. - John
        {
            //TODO deal damage
            if (collision.gameObject.GetComponent<Enemy>())
            {
                collision.gameObject.GetComponent<Enemy>().RemoveHealth(damage);
            }
            else if (collision.gameObject.GetComponent<Player>())
            {
                collision.gameObject.GetComponent<Player>().removeHealth(damage);
            }
            Debug.Log("Deal " + damage + " Damage!");
        }
    }
}
