using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrailUp : MonoBehaviour
{
    public int moveSpeed;



    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
    }
}
