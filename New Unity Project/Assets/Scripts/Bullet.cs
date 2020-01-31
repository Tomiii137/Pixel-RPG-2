using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject hitEffect;
    public float bulletDamage = 20f;
    [SerializeField] float expOffset = -0.2f;

    [SerializeField] LayerMask enemyLayers;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        damageCollision(collision.gameObject);
        Vector3 expPos = new Vector3(transform.position.x, transform.position.y, expOffset);
        GameObject effect = Instantiate(hitEffect, expPos, Quaternion.identity);
        Destroy(effect, 2f);
        Destroy(gameObject);
    }

    private void damageCollision(GameObject _collider)
    {
        if (enemyLayers.value == enemyLayers && _collider.GetComponent<HealthManager>() != null)
        {
            _collider.GetComponent<HealthManager>().getDamage(bulletDamage);
        }
    }
}
