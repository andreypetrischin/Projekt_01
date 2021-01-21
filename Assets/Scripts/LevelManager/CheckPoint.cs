using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public LevelManager levelManager;

   public Vector3 CheckpointPosition;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
           // CheckpointPosition = transform.position = new Vector3(transform.position.x, 0f, 0f);
            levelManager.currentCheckpoint = gameObject;
            Debug.Log(gameObject.name);
            Debug.Log(CheckpointPosition);



        }
    }
}
