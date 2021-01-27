using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{


    //Jump

    public float jumpForce;
    private Rigidbody2D rigidBody;


    //For ground check
    public Transform groundCheck;
    public LayerMask groundLayer;

    //Player movement
    public float speed;
    public float boost;
    public float brake;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       Move();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            SpeedUp(); //Boost
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SpeedDown(); //Brake
        }

        if (Input.GetButtonDown("Jump"))
        {
                Jump();

            Debug.Log("Jump");
        }
    }
    //Useless, for tests 
    void Move()
    {
        rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y); 
    }

    void SpeedUp()
    {
        if (!IsGrounded())
        {
            return;
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(boost, 0f), ForceMode2D.Impulse);
        }
    }

    void SpeedDown()
    {
        if (!IsGrounded())
        {
            return;
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-brake, 0f), ForceMode2D.Impulse);
        }
    }



    bool IsGrounded() //Check ground
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


    void Jump()
    {
        if (!IsGrounded())
        {
            return;
        }
        else
        {
            SaundManagerScript.PlaySound("jump");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}



   


