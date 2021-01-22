using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaundManagerScript : MonoBehaviour
{

    public static AudioClip playHitSound, FireSound, FireSoundUp, jumpSound, enemyDeathSound, levelCompleted;
    public static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        playHitSound = Resources.Load<AudioClip>("PlayerHit");
        FireSound = Resources.Load<AudioClip>("Shoot_up");
       
        jumpSound = Resources.Load<AudioClip>("Jump");
        
        enemyDeathSound = Resources.Load<AudioClip>("Hit_rock");
        levelCompleted = Resources.Load<AudioClip>("LevelComp");


        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "fire":
                audioSrc.PlayOneShot(FireSound);
                break;
           
            case "playerHit":
                audioSrc.PlayOneShot(playHitSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "enemyDeath":
                audioSrc.PlayOneShot(enemyDeathSound);
                break;
            case "LevelComp":
                audioSrc.PlayOneShot(levelCompleted);
                break;
        }
    }
}
