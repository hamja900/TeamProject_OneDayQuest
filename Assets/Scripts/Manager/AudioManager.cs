using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource backfroundMusincSource;

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

        backfroundMusincSource = gameObject.GetComponent<AudioSource>();
        backfroundMusincSource.clip = clip;
        backfroundMusincSource.loop = true;
        GameCheck(1);
        
    }

    public void GameCheck(int checkNum)
    {
        if (checkNum == 1)
        {
            backfroundMusincSource.Play();
        }
        else
        {
            backfroundMusincSource.Stop();
        }
    }

}
