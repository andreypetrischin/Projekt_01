﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKrater : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 3f);
    }
}
