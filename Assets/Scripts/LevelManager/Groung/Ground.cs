using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
     
    public float moveSpeed;
    public bool moveLeft = true;
    public LevelManager levelManager;

    Vector3 GroundPos;
  
    private void Start()
    {
        
        levelManager = FindObjectOfType<LevelManager>();
    }
    // Update is called once per frame
    void Update()
    {
       
        if (moveLeft == true)
        {
            GroundPos = transform.position += transform.right * -moveSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, 0f, 0f);

         

        }
    }
}