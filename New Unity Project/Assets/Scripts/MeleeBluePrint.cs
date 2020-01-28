using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Melee Weapon", menuName ="Weapon/Melee Weapon")]
public class MeleeBluePrint : ScriptableObject
{
    public string wepaonName;
    public int damage;
    public float attackRange;

    public Sprite artwork;
    
}
