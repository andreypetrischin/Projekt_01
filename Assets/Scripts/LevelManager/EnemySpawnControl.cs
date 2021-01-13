using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnControl : MonoBehaviour
{
    public Transform[] spapwnPoints;
    public GameObject[] enemys;

    int randomSpawnPoint, RandomEnemy;
    public static bool spawnAllowed;

    void Start()
    {
        spawnAllowed = true;
        /* InvokeRepeating("SpawnEnemy", 0f, 10f);*/
    }
    void SpawnEnemy()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spapwnPoints.Length);
            RandomEnemy = Random.Range(0, enemys.Length);
            Instantiate(enemys[RandomEnemy], spapwnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SpawnEnemy();
        }


    }
}

