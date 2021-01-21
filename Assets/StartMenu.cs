using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void NewGameBtn( string newGameLevel)
    {
                SceneManager.LoadScene("SampleScene");
     }

    public void ExitGame (string exitGame)
    {
        Application.Quit();
    }
}
