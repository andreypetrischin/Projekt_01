using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveTrail : MonoBehaviour
{
    public int moveSpeed;

    public LevelManager levelManager;

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);



    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {

            levelManager.RespownPlayer();
        }
    }
}
