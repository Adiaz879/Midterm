using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizonatalInput;
    float moveSpeed = 5f;
    float jumpPower = 8f;
    bool isJumping = false;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    //player Movement
    void Update()
    {
        horizonatalInput = Input.GetAxis("Horizontal"); 

        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizonatalInput*moveSpeed, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)  
    {
        isJumping = false;
    }
    
}
