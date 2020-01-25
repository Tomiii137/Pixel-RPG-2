using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] Transform firePoint;
    [SerializeField] GunBluePrint weapon;

    GameObject bulletObject;
    [SerializeField] GameObject weaponLook;
    float bulletSpeed;

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
        if (Input.GetButtonDown("Fire1")) 
        {
            shoot();
        }
    }

    void shoot() 
    {
       GameObject bullet = Instantiate(bulletObject, firePoint.position, firePoint.rotation);
       Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
       rb.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        Destroy(bullet, 20f);
    }
}
