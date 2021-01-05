using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Serializable]
    public class PlayerStats
    {
        public float Health = 1f;
    }
    public PlayerStats playerStats = new PlayerStats();

    public int FallBoundary = -1;

    private void Update()
    {
        if(transform.position.y <= -FallBoundary)
        {
            DamagePlayer(999999);
        }
    }

    public void DamagePlayer(int damage)
    {
        playerStats.Health -= damage;
        if (playerStats.Health <= 0)
        {
            GameMaster.KillPlayer(this);

        }

    }
}