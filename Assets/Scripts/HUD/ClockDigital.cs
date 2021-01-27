using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockDigital : MonoBehaviour
{

    private static float timeCounter;
    public Text counterText;

    private bool isCouting;

    

    

    public void Start()
    {

        timeCounter = 0.0f;
        counterText = GetComponent<Text>() as Text;
        isCouting = true;

    }
    public void Update()
    {
       if(isCouting)
        {
            timeCounter += Time.deltaTime;
            counterText.text = ((int)timeCounter).ToString("000");
        }
    }


    public  void StartCouting()
    {
        isCouting = true;
    }

    public void StopCouting()
    {
        isCouting = false;
    }

    public static void ResetCouting()
    {
        timeCounter = 0.0f;
    }

}
