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
}
