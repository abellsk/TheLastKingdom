using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public int maxMana = 100;
    public int currentMana;

    public HealthBar healthBar;
    public ManaBar manaBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            TakeDamage(20);
        }



        if (Input.GetKeyDown(KeyCode.E))
        {
           UseMana(20);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Regen(20);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RegenMana(20);
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            TakeDamage(20);
            Debug.Log("Hit");
        }

        if (collision.gameObject.tag == "Mana Orbs")
        {
            RegenMana(20);
            Debug.Log("Mana");

            Destroy(collision.gameObject);
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void Regen(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);

    }

    void UseMana(int magic)
    {
        currentMana -= magic;

        manaBar.SetMana(currentMana);
    }

    void RegenMana(int mana)
    {
        currentMana += mana;

        manaBar.SetMana(currentMana);
    }
}
