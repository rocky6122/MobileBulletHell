using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //private variables
    //--------------------
    [SerializeField]
    private Bullet bulletType;

    private int currentHealth;

    [SerializeField]
    private int maxHealth = 100;

    [SerializeField]
    private int speed;


    //---------------------

    //Getter|Setter Functions
    //------------------------------------------
    public Bullet BulletType
    {
        get { return bulletType; }
        private set { bulletType = value; }
    }

    public int CurrentHealth
    {
        get { return currentHealth; }
        private set { currentHealth = value; }
    }

    public int Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    //------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void AddHealth(int value)
    {
        currentHealth += value;
        CheckAndFixHealth();
    }

    public void RemoveHealth(int value)
    {
        currentHealth -= value;
        CheckAndFixHealth();
    }

    void CheckAndFixHealth()
    {
        if (currentHealth <= 0)
        { 
            Destroy(gameObject); 
        }

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
