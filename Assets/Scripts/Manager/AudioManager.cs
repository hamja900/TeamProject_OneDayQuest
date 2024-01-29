using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class AudioDic : SerializableDictionary<string, AudioClip> { }
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("бс AudioSource")]
    public AudioSource audioSource;

    [Header("бс AudioClip")]
    public AudioDic audioClipDic;

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
        audioSource.clip = audioClipDic["StartBgm"];
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

    public void SoundPlayOneShot(string clipName)
    {
        audioSource.PlayOneShot(audioClipDic[clipName]);
    }

    public void AudioManagerDestroy()
    {
        Destroy(gameObject);
    }

}
