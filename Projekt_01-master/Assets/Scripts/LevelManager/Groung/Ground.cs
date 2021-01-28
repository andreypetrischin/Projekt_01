using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
     //Ground move 

    public float moveSpeed;
    public bool moveLeft = true;
   
  

    void Update()
    {
        if (moveLeft)
        {
            Vector3 GroundPos = transform.position += transform.right * -moveSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, 0f, 0f);
        }
    }
}