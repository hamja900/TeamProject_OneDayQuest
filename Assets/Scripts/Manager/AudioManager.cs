using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource backfroundMusincSource;

    private static AudioManager instance;


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
        backfroundMusincSource.Play();
    }


}
