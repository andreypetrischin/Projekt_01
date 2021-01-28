using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCount : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreScript.scoreValue += 100;
        }
    }
  

}
