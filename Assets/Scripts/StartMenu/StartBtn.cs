using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public GameObject load;
    public void OnClickSence()
    {
        AudioManager.instance.SoundPlayOneShot("ButtonClick");
        Thread.Sleep(300);
        load.SetActive(true);
    }

}
