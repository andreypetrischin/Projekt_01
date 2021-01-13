using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{



    private void Awake()
    {
        Destroy(gameObject, 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Enemy")
        {
            Destroy(gameObject, 1f);

            Debug.Log("Destroyed");
        }
    }
}
