using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public AudioClip click;
    public GameObject load;
    public void OnClickSence()
    {
        AudioManager.instance.audioSource.PlayOneShot(click);
        Thread.Sleep(300);
        load.SetActive(true);
    }

}
