using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    [SerializeField] BoxCollider2D colliderBox;

    [SerializeField] float maxHealth = 100f;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void getDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            die();
        }
    }


    void die()
    {
        SendMessage("playOnDeath");
        colliderBox.enabled = false;
        if (colliderBox.GetComponent<SpriteRenderer>() != null) 
        {
            colliderBox.GetComponent<SpriteRenderer>().sortingOrder -= 1;
        }
        

    }

    public float getMaxHealth() 
    {
        return maxHealth;
    }

}
