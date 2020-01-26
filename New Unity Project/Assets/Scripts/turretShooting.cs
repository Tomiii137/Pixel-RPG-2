using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretShooting : MonoBehaviour
{

    [SerializeField] Transform firePoint;
    [SerializeField] GunBluePrint weapon;

    GameObject bulletObject;
    [SerializeField] GameObject weaponLook;
    float bulletSpeed;
    float elapsed = 1f;

    private void Start()
    {
        bulletObject = weapon.bulletPrefab;
        bulletSpeed = weapon.bulletForce;
        Sprite weaponDesign = weaponLook.GetComponent<Sprite>();
        weaponDesign = weapon.gunSprite;
    }
    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("shoot", 2, 1);
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletObject, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        Destroy(bullet, 20f);
    }
}
