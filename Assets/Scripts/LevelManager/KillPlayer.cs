using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public LevelManager levelManager;
    public Ground ground;
    public GameObject prefab;
    Animation anim;


    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        ground = FindObjectOfType<Ground>();
;       
    }
    
    void Update()
    {
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player" )
        {
           /* GameObject obj = Instantiate(prefab) as GameObject;
            anim = obj.GetComponent<Animation>();*/
            LiveScript.liveValue -= 1;


          
          //  levelManager.RespawnRoad();
         
          
        }
    }
}
