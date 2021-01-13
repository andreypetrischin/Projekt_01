using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
   
    private PlayerController player;

    public bool CanPause;
    private Vector3 spawnPosition;


   

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
      
    }
    // Update is called once per frame
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
    public void RespownPlayer()
    {
        player.transform.position = currentCheckpoint.transform.position;
       // Instantiate(player);
        Debug.Log("Player " + player);


    }
}
