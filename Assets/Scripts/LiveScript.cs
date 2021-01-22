using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveScript : MonoBehaviour
{
    public static int liveValue = 2;
    Text X;

    // Start is called before the first frame update
    void Start()
    {
        X = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        X.text = " " + liveValue;
  
    }
    
}
