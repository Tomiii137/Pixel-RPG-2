using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] GameObject hitEffect;

    [SerializeField] float expOffset = -0.2f;

    [SerializeField] float maxHealth = 100f;
    protected Animator anim;
    private float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
    }

    public void getDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            die();
        }
    }


    //todo: overwork integrate in general getDamage function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            getDamage(collision.gameObject);
        }
    }


    void getDamage(GameObject _bullet)
    {
        Bullet hit = _bullet.GetComponent<Bullet>();
        currentHealth -= hit.bulletDamage;


        if (currentHealth <= 0)
        {
            die();
        }


    }


    void die()
    {
        //Alles was player betrifft herauskopieren, Rest löschen
        /*Vector3 spwanPos = new Vector3(transform.position.x, transform.position.y, expOffset);
        GameObject effect = Instantiate(hitEffect, spwanPos, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);*/
        anim.SetBool("boom" , true);
    }
}
