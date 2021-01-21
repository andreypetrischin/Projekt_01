using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 Pos;

    private void Start()
    {
         Pos = transform.position = new Vector3(12f, 7.5f, 0f);
    }


    void Update()
    {
        transform.position = new Vector3 (player.position.x, 7.5f, 0f);

    }
}
