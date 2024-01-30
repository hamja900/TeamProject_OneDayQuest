using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour
{
    private AudioManager audioManager;
    public void OnClickBackBtn()
    {
        try
        {
            Save();
        }
        catch
        {
         
        }
        AudioManager.instance.AudioManagerDestroy();
        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1.0f;
    }

    void Save()
    {
        PlayerPrefs.SetInt("Point", gameManager.I.point);
        PlayerPrefs.SetInt("ExtraSpeed", System.Convert.ToInt16(gameManager.I.speedItem));
        PlayerPrefs.SetInt("ExtraBugCount", System.Convert.ToInt16(gameManager.I.bugItem));
    }

}
