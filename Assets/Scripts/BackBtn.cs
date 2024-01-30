using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour
{
    private AudioManager audioManager;
    public void OnClickBackBtn()
    {
        AudioManager.instance.AudioManagerDestroy();
        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1.0f;
    }

}
