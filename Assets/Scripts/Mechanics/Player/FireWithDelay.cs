using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWithDelay : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D bullet;
    [SerializeField]
    private Rigidbody2D bulletUp;


    [SerializeField]
    private Transform barrel;

    [SerializeField]
    private Transform barrelup;


    public float bulletSpeed;

    public float fireRate;
    public float nextFire;

    public float fireRateUp;
    public float nextFireUp;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftAlt) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.AddForce(barrel.right * bulletSpeed);
            Destroy(spawnedBullet, 1f);
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt) && Time.time > nextFireUp)
        {
            nextFireUp = Time.time + fireRateUp;
            var spawnedBulletUp = Instantiate(bulletUp, barrelup.position, barrelup.rotation);
            spawnedBulletUp.AddForce(barrelup.up * bulletSpeed);

        }
       /* if (Vector2.Distance(transform.position, bullet.transform.position)> 1)
        {
            Destroy(bullet);
            Debug.Log("Destruyed");
        }*/
    }
}
