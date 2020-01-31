using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathManagerTurret : MonoBehaviour
{

    void playOnDeath()
    {
        Debug.Log("death");
        Destroy(gameObject);
    }
}
