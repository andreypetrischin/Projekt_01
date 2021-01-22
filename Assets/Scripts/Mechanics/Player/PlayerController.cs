using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public GameObject prefab;
    Animation anim;

    //Jump

    public float jumpForce;
    private Rigidbody2D rigidBody;

    public Transform groundCheck;
    public LayerMask groundLayer;


    public float speed;
    public float boost;
    public float brake;


    public int HealthPoints = 3;


    private Ground ground;

    Vector3 startPos;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        ground = FindObjectOfType<Ground>();

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

            Debug.Log("Jump");
        }
    }

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
            ScoreScript.scoreValue += 50;
            SaundManagerScript.PlaySound("jump");
               gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}



   


