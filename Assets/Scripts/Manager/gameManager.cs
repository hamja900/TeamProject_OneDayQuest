using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public GameObject rain;
    private RainDrops raindrops;
    private CarrotCrowImages growImages;
    public DropSO[] dropSO;
    public GameObject carrotObj;

    public GameObject rainSpawnPosition;
    public Text StageText; // 당근 성장단계 텍스트
    public Text MaxCarrotTxt;
    public Text CurrentTxt;

    public GameObject gameOver;
    public GameObject gameClear;

    //public AudioSource endAudioSource;
    //public AudioClip clear;
    //public AudioClip over;

    public int current = 0;
    public int stage = 1;
    public int maxcount = 0;
    public int maxCarrot = 3;
    public int carrotCount = 0;
    public int maxBug = 3;
    public int bugCount = 0;

    void Awake()
    {
        I = this;
        raindrops = rain.GetComponent<RainDrops>();
        growImages = carrotObj.GetComponent<CarrotCrowImages>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartDrop", 0, 0.5f);
        InvokeRepeating("HighStartDrop", 2f, 0.8f);
        InvokeRepeating("BugStart", 1f, 1.5f);

        AudioManager.instance.audioSource.clip = AudioManager.instance.gameBgmClip;
        GameReset();
    }

    void GameReset()
    {
        current = 0;
        stage = 1;
        maxcount = 0;
        carrotCount = 0;
        bugCount = 0;
        Time.timeScale = 1f;
        MaxCarrotTxt.text = maxCarrot.ToString();
        AudioManager.instance.GameCheck(true);
    }

    // Update is called once per frame
    void Update()
    {
        StageText.text = stage.ToString();
        growImages.CarrotImage();
    }
    
    public void StartDrop()
    {
        float x = UnityEngine.Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
        DropManager.instance.DropFromSky(transform.position, dropSO[0]);
    }
    public void HighStartDrop()
    {
        float x = UnityEngine.Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
        DropManager.instance.DropFromSky(transform.position, dropSO[1]);
    }
    public void BugStart()
    {
        float x = UnityEngine.Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
        DropManager.instance.DropFromSky(transform.position, dropSO[2]);


    }

    public void GetPoint(int array)
    {
        current += dropSO[array].score;
        if (current < 0)
        {
            current = 0;
        }

    }
    
    public void BugCount()
    {
        bugCount++;

        if(bugCount == maxBug)
        {
            GameOver();
        }
    }

    public void GrowthCarrot() //물방울 모으면 단계 상승
    {
        maxcount = stage * 3;

        if (stage == 3 && current >= maxcount)
        {
            carrotCount++;
            CurrentTxt.text = carrotCount.ToString();
            if(maxCarrot == carrotCount)
            {
                GameClear();
            }
            AudioManager.instance.SoundPlayOneShot(AudioManager.instance.carrotHarvest);
            stage = 0;
        }
        if (current >= maxcount)
        {
            stage++;
            current = 0;
        }
        

    } 
    
    public void GameOver()
    {
        AudioManager.instance.GameCheck(false);
        AudioManager.instance.SoundPlayOneShot(AudioManager.instance.gameOver);
        gameOver.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void GameClear()
    {
        AudioManager.instance.GameCheck(false);
        AudioManager.instance.SoundPlayOneShot(AudioManager.instance.gameClear);
        gameClear.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void ReStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void StartScene()
    {

        AudioManager.instance.AudioManagerDestroy();

        Time.timeScale = 1f;

        SceneManager.LoadScene("StartScene");
    }


}

