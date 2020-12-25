using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrail : MonoBehaviour
{

    public int moveSpeed;
   

  
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
     


    }
}
