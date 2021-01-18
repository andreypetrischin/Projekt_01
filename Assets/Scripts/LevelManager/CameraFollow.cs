using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    public Transform target;
      public float moveSpeed;







      void FixedUpdate()
      {
              Vector3 position = transform.position;

              position.x = target.transform.position.x * moveSpeed * Time.deltaTime;
              transform.position = position;



      }

    /* private void Update()
     {
         if (target == null)
         {
             target = FindPlayer();
             return;
         }

         //etc.
     }

     private Transform FindPlayer()
     {
         Transform searchResult = GameObject.FindGameObjectWithTag("Player").transform;

         if (searchResult == null)
         {
             Debug.LogWarning("Player object could not be found.");
             return null;
         }
         else
         {
             return searchResult;
         }
     }*/

}
