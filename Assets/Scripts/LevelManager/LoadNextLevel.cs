using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour
{
    public void NextLevel()
    {
        ClockDigital.ResetCouting();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
