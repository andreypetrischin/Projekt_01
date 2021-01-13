using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFire : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D bullet;

    [SerializeField]
    private Transform barrel;

    private float bulletSpeed = 500f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            var spawnBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnBullet.AddForce(barrel.right * bulletSpeed);
        }
    }
}
