﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveTrail : MonoBehaviour
{
    public int moveSpeed;



    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);



    }
}
