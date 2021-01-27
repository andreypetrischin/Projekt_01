using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // For destroy player bullets 

    private void Awake()
    {
        Destroy(gameObject, 0.7f);
    }
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Enemy")
        {
            Destroy(gameObject, 1);
        }
    }
}
