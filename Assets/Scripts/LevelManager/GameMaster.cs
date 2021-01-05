using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;

    private void Start()
    {
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }
    public Transform playerPerfab;
    public Transform spawnPoint;
    public int spawnDelay = 2;

    public IEnumerator RespawnPlayer()
    {
       
        yield return new WaitForSeconds(spawnDelay);

        Instantiate(playerPerfab, spawnPoint.position, spawnPoint.rotation);
     
    }

    public static void KillPlayer (Player player)
    {
        Destroy(player.gameObject);
        gm.StartCoroutine(gm.RespawnPlayer());
        SceneManager.LoadScene("SampleScene");
    }
}
