using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private float Healt = 1f;

    private void Update()
    {
        if(Healt<=0)
        {
            Destroy(gameObject);
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Bullet")
        {
           
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("WORK");
        }
    }*/

   void Damage(float damage)
    {

        Healt -= damage;
    }
}
