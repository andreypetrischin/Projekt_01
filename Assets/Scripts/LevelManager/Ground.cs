using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float moveSpeed;
    public bool moveLeft = true;

    // Update is called once per frame
    void Update()
    {

        if (moveLeft)
        {
            transform.position += transform.right * -moveSpeed * Time.deltaTime;
        }

       
    }
}