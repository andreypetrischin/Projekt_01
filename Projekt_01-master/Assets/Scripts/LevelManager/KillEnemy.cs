using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    public GameObject EnemyDestroyEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals ("Bullet"))
        {
            Instantiate(EnemyDestroyEffect, transform.position, Quaternion.identity);
            
            SaundManagerScript.PlaySound("enemyDeath");
            ScoreScript.scoreValue += 200;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
}
