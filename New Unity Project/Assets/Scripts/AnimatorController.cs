using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] GameObject player;
    protected Animator anim;
    Vector2 looksAt;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        looksAt = player.GetComponent<CharacterMovement>().lookDirection;
        anim.SetFloat("lookX", looksAt.x);
        anim.SetFloat("lookY", looksAt.y);

    }
}
