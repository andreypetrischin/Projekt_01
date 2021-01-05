using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{


    //Jump

    public float jumpForce;
    private Rigidbody2D rigidBody;
   
    public Transform groundCheck;
    public LayerMask groundLayer;


    public float speed;
    public float boost;
    public float brake;


    public  float healthAmount;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            SpeedUp();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SpeedDown();
        }

        if (Input.GetButtonDown("Jump"))
        {

            Jump();
        }


        if (healthAmount <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("SampleScene");
        }

        }
    void Move()
    {
       
            rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
        
    }


    void SpeedUp()
    {
        rigidBody.velocity = new Vector2(speed + boost, rigidBody.velocity.y);
    }

    void SpeedDown()
    {
        rigidBody.velocity = new Vector2 (speed - brake, rigidBody.velocity.y);
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

     void Jump()
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


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Pit"))
            healthAmount -= 11f;
        if (col.gameObject.name.Equals("FirePoint"))
            healthAmount -= 11f;
    }
}



   


