using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("бс AudioSource")]
    public AudioSource audioSource;

    [Header("бс AudioClip")]
    public AudioClip startBgmClip;
    public AudioClip gameBgmClip;
    public AudioClip carrotHarvest;
    public AudioClip gameOver;
    public AudioClip gameClear;
    public AudioClip fail;

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

        DontDestroyOnLoad(gameObject);
    }



    private void Start()
    {
        audioSource.clip = startBgmClip;
        audioSource.loop = true;
        GameCheck(true);
    }

    public void GameCheck(bool isRunBgm)
    {
        if (isRunBgm)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }

        audioSource.loop = true;
    }

    public void SoundPlayOneShot(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }

    public void AudioManagerDestroy()
    {
        Destroy(gameObject);
    }

}
