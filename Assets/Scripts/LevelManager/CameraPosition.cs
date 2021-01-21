using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{

    private Vector3 CameraPos;

    // Start is called before the first frame update
    void Start()
    {
        CameraPos = transform.position = new Vector3(12f, 7.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
       // CameraPos = transform.position = new Vector3(12f, 7.5f, 0f);

     //   Debug.Log(CameraPos);
    }
}
 