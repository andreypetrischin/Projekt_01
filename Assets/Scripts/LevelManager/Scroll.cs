using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    //Background Scroll


    public float scrollSpeed;
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {

        rend.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0f);
    }

}

