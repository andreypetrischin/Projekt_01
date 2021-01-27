using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    private PlayerController player;
    public bool CanPause;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 0;
        }
        if (Input.GetKey(KeyCode.P))
        {
            if (CanPause)
            {
                Debug.Log("pause");
                Time.timeScale = 0;
                CanPause = false;
            }
            else
            {
                Time.timeScale = 1;
                CanPause = true;
            }
        }
    }
    public void RespawnRoad()
    {
        this.player.transform.position = currentCheckpoint.transform.position;
        Vector3 position = transform.position;
        position.y = 0;
    } 
}
   