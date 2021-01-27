using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockDigital : MonoBehaviour
{
    public Text counterText;

    public float seconds;
    public float minutes;

    public void Start()
    {
        counterText = GetComponent<Text>() as Text;

    }
    public void Update()
    {
        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);

        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
