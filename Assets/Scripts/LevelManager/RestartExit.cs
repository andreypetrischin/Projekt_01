using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartExit : MonoBehaviour
{
    public GameObject parent;



    public void NewGameBtn(string newGameLevel)
    {
        LiveScript.liveValue = 4;
        ScoreScript.scoreValue = 0;
        AudioListener.volume = 1;
        gameObject.SetActive(false);
        SceneManager.LoadScene(1);
    }

    public void ExitGame(string exitGame)
    {
       
        SceneManager.LoadScene(0);
    }
}
