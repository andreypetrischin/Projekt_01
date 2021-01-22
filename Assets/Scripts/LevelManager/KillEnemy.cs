﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals ("Bullet"))
        {
            SaundManagerScript.PlaySound("enemyDeath");
            ScoreScript.scoreValue += 200;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
