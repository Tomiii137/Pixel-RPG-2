using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Camera playerCam;
    [SerializeField] float speed = 3.1f;


    Vector2 movement;

    Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        // movement input
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        //rotation input
        mousePos = playerCam.ScreenToWorldPoint(Input.mousePosition);

    }
    // Update is called once per frame
    void FixedUpdate()
    {

        //movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        //rotation
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }


}
