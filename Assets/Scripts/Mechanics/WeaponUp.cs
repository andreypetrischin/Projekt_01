using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUp : MonoBehaviour
{

    public float fireRate = 1;
    public float damage = 1;
    public LayerMask notToHit;
    public float shootDistanceUp;
    public float timeToSpawnEffectUp;
    public float effectSpawnRateUp;




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
        if (fireRate == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                Shoot();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftAlt) && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Vector2 endPosition = new Vector2(firePoint.position.y, firePoint.position.x);
        Vector2 firePointPosition = new Vector2(firePoint.position.y, firePoint.position.x);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, endPosition - firePointPosition, shootDistanceUp, notToHit);
        if (Time.time > timeToSpawnEffectUp)
        {
            Effect();
            timeToSpawnEffectUp = Time.time + 1 / effectSpawnRateUp;
        }

        Debug.DrawLine(firePointPosition, (endPosition - firePointPosition) * shootDistanceUp, Color.cyan);
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
