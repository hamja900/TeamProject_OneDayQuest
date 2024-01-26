using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public AudioClip click;

    public void OnClickSence()
    {
        AudioManager.instance.audioSource.PlayOneShot(click);
        SceneManager.LoadScene("GameScene");
    }

}
