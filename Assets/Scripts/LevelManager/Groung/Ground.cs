using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
     
    public float moveSpeed;
    public bool moveLeft = true;
    public LevelManager levelManager;

    public Vector2 road;
    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (moveLeft == true)
        {
           road =   transform.position += transform.right * -moveSpeed * Time.deltaTime;
        }
    }
}