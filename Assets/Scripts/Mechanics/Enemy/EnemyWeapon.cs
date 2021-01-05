using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public float fireRate = 0;
    public float damage = 1;
    public LayerMask notToHit;
    public float shootDistance;
    public float timeToSpawnEffect;
    public float effectSpawnRate;




    public Transform BulletTrailPrefab;


    float timeToFire = 0;
    Transform firePoint;
    void Awake()
    {
        firePoint = transform.Find("FirePoint");
        if (firePoint == null)
        {
            Debug.LogError("No fire Point");
        }
    }

    void Update()
    {
        Shoot();
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

        Debug.DrawLine(firePointPosition, (endPosition - firePointPosition) * shootDistance, Color.cyan);
        if (hit.collider != null)
        {
            Debug.DrawLine(firePointPosition, hit.point, Color.red);
            Debug.Log("We hit" + hit.collider.name + " and did" + damage + " damage");
        }
    }

    void Effect()
    {
        Instantiate(BulletTrailPrefab, firePoint.position, firePoint.rotation);
    }
}
