using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            removeHealth(10);
        }
    }

    void checkAndFixHealth()
    {
        if(currentHealth < 0) { currentHealth = 0; }
        if(currentHealth > maxHealth) { currentHealth = maxHealth; }
    }

    void removeHealth(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
        checkAndFixHealth();
    }
    void addHealth(int amount)
    {
        currentHealth += amount;
        healthBar.setHealth(currentHealth);
        checkAndFixHealth();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "basicEnemy")
        {
            removeHealth(10);
        }
        if(collision.gameObject.tag == "health")
        {
            addHealth(10);
        }
    }
}
