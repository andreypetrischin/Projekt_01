﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public LevelManager levelManager;
    public Ground ground;
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        ground = FindObjectOfType<Ground>();
;       
    }
    
    void Update()
    {
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player" )
        {
            LiveScript.liveValue -= 1; 
            /*levelManager.RespownPlayer();
            levelManager.RespawnRoad(); */
          
        }
    }
}