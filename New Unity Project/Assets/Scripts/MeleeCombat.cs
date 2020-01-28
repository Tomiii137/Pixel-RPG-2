using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeCombat : MonoBehaviour
{
    [SerializeField] MeleeBluePrint weapon;                                         
    [SerializeField] Animator weaponAnimator;
    [SerializeField] Transform attackPoint;
    [SerializeField] LayerMask enemieLayers;

    float attackRange;
    int attackDamage;

    private void Start()
    {
        attackRange = weapon.attackRange;
        attackDamage = weapon.damage;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")) 
        {
            Attack();
        }
    }

    void Attack()
    {
        //animation
        weaponAnimator.SetTrigger("Attack");

        //hit detection
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemieLayers);

        // Damage
        foreach(Collider2D enemy in hitEnemies) 
        {
            enemy.GetComponent<HealthManager>().getDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        attackRange = weapon.attackRange;
        if (attackPoint == null)
        {
            Debug.Log("meh");
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
