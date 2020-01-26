using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponDisplay : MonoBehaviour
{
    [SerializeField] MeleeBluePrint weapon;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(weapon.wepaonName);
    }

}
