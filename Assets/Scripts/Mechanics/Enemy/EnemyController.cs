using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float helth;


    private void Update()
    {
        if (helth <= 0)
            Destroy(gameObject);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("FirePoint"))
            helth -= 11f;
    }
}
