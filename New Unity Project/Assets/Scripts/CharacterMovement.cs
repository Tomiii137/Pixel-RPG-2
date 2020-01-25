using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Camera playerCam;
    [SerializeField] float speed = 3.1f;


    float horizontalInput;
    float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        // movement input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //rotation input
        playerCam.

    }
    // Update is called once per frame
    void FixedUpdate()
    {

        //movement
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed * Time.fixedDeltaTime;
        rb.AddRelativeForce(movement);
    }


}
