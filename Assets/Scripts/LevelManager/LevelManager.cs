using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    private PlayerController player;
    public bool CanPause;
    private Vector3 spawnPosition;


    public Ground ground;
   

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        ground = FindObjectOfType<Ground>();

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

      //  SceneManager.LoadScene("SampleScene");
        this.player.transform.position = currentCheckpoint.transform.position;
        Debug.Log("Player " + player);
       // Instantiate(player);
        


    }

    public void RespawnRoad()
    {
        ground.road = currentCheckpoint.transform.position;
       
    }
}
