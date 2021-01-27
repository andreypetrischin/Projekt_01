using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class DestroyObject : MonoBehaviour
{



    public GameObject prefab;
    Animation anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            ScoreScript.scoreValue += 150;
            Destroy(collision.gameObject);
            GameObject obj = Instantiate(prefab) as GameObject;
            anim = obj.GetComponent<Animation>();
        }
    }
}
