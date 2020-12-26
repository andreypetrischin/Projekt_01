using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    public Transform target;

     float nextTimeToSearch;

    void FixedUpdate()
    {
        if (target == null)
        {
            FindPlayer();
        }
           

        Vector3 position = transform.position;
        position.x = target.transform.position.x;
        transform.position = position;
    }

    void FindPlayer()
    {
        if (nextTimeToSearch <= Time.time)
        {
        GameObject searchResoult =   GameObject.FindGameObjectWithTag("Player");
            if (searchResoult !=null)
            {
                target = searchResoult.transform;
                nextTimeToSearch = Time.time + 0.5f;
            }
        }
    }
}
