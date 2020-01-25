using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField] GameObject hitEffect;
    [SerializeField] float health = 100f;
    // Start is called before the first frame update

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
        health -= hit.bulletDamage;

        if (health <= 0)
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            Destroy(gameObject);
        }


    }
}
