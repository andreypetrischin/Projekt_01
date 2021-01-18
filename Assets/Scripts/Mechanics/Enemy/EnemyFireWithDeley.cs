using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireWithDeley : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D bullet;
    [SerializeField]
    private Transform barrel;
    public float bulletSpeed;
    public float fireRate;
    public float nextFire;

  


    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.AddForce(barrel.right * bulletSpeed);
            Destroy(spawnedBullet, 1f);
        }
       
    }
}
