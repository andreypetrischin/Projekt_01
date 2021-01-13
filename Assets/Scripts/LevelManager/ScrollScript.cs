using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{

    float scrollSpeed = -5f;
    Vector2 startsPos;
    // Start is called before the first frame update
    void Start()
    {
        startsPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.deltaTime * scrollSpeed, 20);
        transform.position = startsPos + Vector2.right * newPos;
    }
}
