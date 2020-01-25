using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Weapon", fileName ="Gun")]
public class GunBluePrint : ScriptableObject
{
    public string weaponName;
    public float Damage;
    public float bulletForce;
    public GameObject bulletPrefab;
    public Sprite gunSprite;
}
