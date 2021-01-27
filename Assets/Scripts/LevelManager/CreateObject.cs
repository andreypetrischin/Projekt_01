using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Quaternion MyGameObjectRotation;
    public Transform Spawnpoint;
    public GameObject Prefab;
 
    void Update()
    {
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {

            Instantiate(Prefab, Spawnpoint.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}