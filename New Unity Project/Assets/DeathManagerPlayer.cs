using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManagerPlayer : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    void playOnDeath()
    {
        Debug.Log("death");
        Invoke("respawn", 1.2f);
        anim.SetBool("boom", true);
    }

    void respawn() 
    {
        transform.position = new Vector2(0, 0);
        anim.SetBool("boom", false);
        GetComponent<HealthManager>().currentHealth = GetComponent<HealthManager>().getMaxHealth();
    }
}
