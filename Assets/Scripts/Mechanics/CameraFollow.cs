using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    public Transform target;

    void FixedUpdate()
    {
        Vector3 position = transform.position;
        position.x = target.transform.position.x;
        transform.position = position;
    }
}
