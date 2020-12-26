using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    //Jump

    public float jumpForce;
    private Rigidbody2D rigidBody;
   
    public Transform groundCheck;
    public LayerMask groundLayer;





    //Move
    public float speed;
    public float movement;
    private bool slow = false;
    public float brake;
    private bool quickly = false;
    public float boost;



    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
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

       


        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
           
                Jump();
         
        }
     
    }


    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }


    public void Jump()
    {
        if (!IsGrounded())
        {
            return;
        }
        else
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
     
    }
}



   


