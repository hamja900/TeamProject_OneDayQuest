using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip clip;
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

        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.loop = true;
        GameCheck(1);
        
    }

    public void GameCheck(int checkNum)
    {
        if (checkNum == 1)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }

}
