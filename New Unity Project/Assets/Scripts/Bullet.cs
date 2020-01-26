using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject hitEffect;
    public float bulletDamage = 20f;
    [SerializeField] float expOffset = -0.2f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 expPos = new Vector3(transform.position.x, transform.position.y, expOffset);
        GameObject effect = Instantiate(hitEffect, expPos, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
