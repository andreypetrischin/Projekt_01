using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrail : MonoBehaviour
{

    public int moveSpeed;
   /* public float lifeTime;

    public GameObject destroyEffect;
*/

 /*   private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }*/



    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);

     
                
    }

   /* void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
*/

}
