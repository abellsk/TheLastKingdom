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

    public int damageAmount = 20;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);

        anim = GetComponentInChildren<Animator>();  
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

    //private void OnCollisionEnter(Collision collision)
    //{
    //if(collision.gameObject.tag == "Enemy")
    //{
    //TakeDamage(20);
    //Debug.Log("Hit");
    //}



    //if (collision.gameObject.tag == "Mana Orbs")
    //{
    //RegenMana(20);
    //Debug.Log("Mana");

    //Destroy(collision.gameObject);
    //}

    //}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("hit");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Death();
            
        }
    }

    void Regen(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);

    }

    private void Death()
    {
        Debug.Log("Dead");
        anim.SetTrigger("isDead");
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

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
