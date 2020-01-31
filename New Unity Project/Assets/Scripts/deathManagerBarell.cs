using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathManagerBarell : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void playOnDeath() 
    {
        Debug.Log("boom");
        anim.SetBool("boom", true);
    }
}
