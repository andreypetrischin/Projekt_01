using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    //End Level


    public GameManager gameManager;

    GameObject backgroundAudio;

    private void Awake()
    {
        backgroundAudio = GameObject.Find("BackgroundAudio");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            backgroundAudio.SetActive(false);
            SaundManagerScript.PlaySound("LevelComp");
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.enabled = false;
            backgroundAudio.SetActive(false);
            gameManager.CompleteLevel(); // Complete Level start animation
         //   LiveScript.liveValue += 1; 
        }
    }

}
