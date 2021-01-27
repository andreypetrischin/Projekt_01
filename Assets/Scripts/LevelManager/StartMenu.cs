using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void NewGameBtn( string newGameLevel)
    {
        LiveScript.liveValue = 4;
        ScoreScript.scoreValue = 0;
        AudioListener.volume = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame (string exitGame)
    {
        Application.Quit();
    }
}
