using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip startBGM;
    public AudioSource audioSource;

    public static AudioManager instance;

    public int checkNum = 1;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
           
        }
        else
        {
            Destroy(gameObject);
            
        }
    }





}
