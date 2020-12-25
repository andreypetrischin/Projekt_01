using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float movement;
    private bool slow = true;
    public float brake;
    private bool quickly = true;
    public float boost;

    public float jumpForce;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;



    private Rigidbody2D rigidBody;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }


 /*   void Jump()
    {
        rigidBody.velocity = Vector2.up * jumpForce;
    }*/


    // Update is called once per frame
    void Update()
    {
        if (movement > 0f)
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
        }

        slow = Input.GetKey(KeyCode.LeftArrow);

        if (slow == true)
        {
            rigidBody.velocity = new Vector2(movement * brake, rigidBody.velocity.y);
        }

        quickly = Input.GetKey(KeyCode.RightArrow);

        if (quickly == true)
        {
            rigidBody.velocity = new Vector2(speed + boost, rigidBody.velocity.y);
        }

       isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        if (Input.GetKey(KeyCode.Space))
        {
            if(isGrounded)
            {
                rigidBody.velocity = Vector2.up * jumpForce;

               
            }
        }
    }
}
