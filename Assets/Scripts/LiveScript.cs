using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LiveScript : MonoBehaviour
{
    public GameObject parent;
    GameObject backgroundAudio;
   

    private void Awake()
    {
        backgroundAudio = GameObject.Find("BackgroundAudio");
    }
    public static int liveValue = 2;
    Text Live;
    void Start()
    {
        Live = GetComponent<Text>();
    }
    void Update()
    {
        Live.text = " " + liveValue;

        if(liveValue < 0)
        {
            backgroundAudio.SetActive(false);
            SaundManagerScript.PlaySound("GameOver");
           
            parent.transform.GetChild(0).gameObject.SetActive(true);
            AudioListener.volume = 0;
        }
    }
   
}
