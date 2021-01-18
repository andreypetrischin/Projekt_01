using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public float fireRate;
    public float damage = 1;
    public LayerMask notToHit;
    public float shootDistance;
    public float timeToSpawnEffect;
    public float effectSpawnRate;

 //   private float fireRate = 2f;
    private float nextFire = 4f;


    public Transform BulletTrailPrefab;


   // float timeToFire = 0;
    Transform firePoint;
    void Awake()
    {
        firePoint = transform.Find("Bullet");
        if (firePoint == null)
        {
            Debug.LogError("No fire Point");
        }
    }

    void Update()
    {
        if (Time.time > nextFire)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector2 endPosition = new Vector2(firePoint.position.y, firePoint.position.x);
        Vector2 firePointPosition = new Vector2(firePoint.position.y, firePoint.position.x);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, endPosition - firePointPosition, shootDistance, notToHit);
        if (Time.time > timeToSpawnEffect)
        {
            Effect();
            timeToSpawnEffect = Time.time + 1 / effectSpawnRate;
        }

       
    }

    void Effect()
    {
        Instantiate(BulletTrailPrefab, firePoint.position, firePoint.rotation);
    }
}
