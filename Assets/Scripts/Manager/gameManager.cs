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

    [Header("■ SO")]
    public DropSO[] dropSO;


    [Header("■ Text")]
    public Text StageText; // 당근 성장단계 텍스트
    public Text MaxCarrotTxt;
    public Text CurrentTxt;

    [Header("■ GameObject")]
    public GameObject rain;
    public GameObject difficultyPopUp;
    public GameObject panel;
    public GameObject carrotObj;
    public GameObject rainSpawnPosition;
    public GameObject gameOver;
    public GameObject gameClear;
    public GameObject plusOne;
    public GameObject plusOnePoint;

    private CarrotCrowImages growImages;
    private AddCarrot addCarrot;
    private RainDrops raindrops;

    #region 옵션
    [HideInInspector] public int current = 0;
    [HideInInspector] public int stage = 1;
    [HideInInspector] public int maxcount = 0;
    [HideInInspector] public int maxCarrot;
    [HideInInspector] public int carrotCount = 0;
    [HideInInspector] public int maxBug = 3;
    [HideInInspector] public int bugCount = 0;
    [HideInInspector] public int difficultyType;
    #endregion

    public int totalScore;
    public int point = 0;
    public bool speedItem =false;
    public bool bugItem = false;

    void Awake()
    {
        I = this;
        raindrops = rain.GetComponent<RainDrops>();
        growImages = carrotObj.GetComponent<CarrotCrowImages>();
        addCarrot = plusOne.GetComponent<AddCarrot>();
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        if (difficultyPopUp || panel)
        {
            Time.timeScale = 0;
        }

        difficultyType = 3;
        AudioManager.instance.audioSource.clip = AudioManager.instance.audioClipDic["GameBgm"];
        GameReset();

    }

    public void Easy()
    {
        InvokeRepeating("StartDrop", 0, 0.5f);
        InvokeRepeating("HighStartDrop", 2f, 0.8f);
        InvokeRepeating("BugStart", 1f, 1.5f);
    }
    public void Normal()
    {
        gameManager.I.MaxCarrotTxt.text = 5.ToString();
        InvokeRepeating("StartDrop", 0, 0.5f);
        InvokeRepeating("HighStartDrop", 2f, 1.2f);
        InvokeRepeating("BugStart", 1f, 0.8f);
    }
    public void Hard()
    {
        gameManager.I.MaxCarrotTxt.text = 8.ToString();
        InvokeRepeating("StartDrop", 0, 0.5f);
        InvokeRepeating("HighStartDrop", 2f, 2f);
        InvokeRepeating("BugStart", 1f, 0.5f);

        
    }

    void GameReset()
    {
        point = 0;
        current = 0;
        stage = 1;
        maxcount = 0;
        carrotCount = 0;
        bugCount = 0;
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

    public void GetScoreNpoint(int array)
    {
        current += dropSO[array].score;
        point += dropSO[array].point;
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
            stage = 0;
            carrotCount++;
            CurrentTxt.text = carrotCount.ToString();
            if (maxCarrot == carrotCount)
            {
                GameClear();
            }

            AudioManager.instance.SoundPlayOneShot("CarrotHarvest");
            addCarrot.addCarrotAnim();
            
            
            
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
        AudioManager.instance.SoundPlayOneShot("GameOver");

        gameOver.SetActive(true);
        Time.timeScale = 0.0f;
        
    }

    public void GameClear()
    {
        AudioManager.instance.GameCheck(false);
        AudioManager.instance.SoundPlayOneShot("GameClear");
        
        gameClear.SetActive(true);
        Time.timeScale = 0.0f;

    }

    public void ReStart()
    {
        totalScore += point;
        SaveData();
        SceneManager.LoadScene("GameScene");
    }

    public void StartScene()
    {
        AudioManager.instance.AudioManagerDestroy();
        totalScore += point;
        SaveData();

        Time.timeScale = 1f;

        SceneManager.LoadScene("StartScene");
    }

    void LoadData()
    {
        PlayerPrefs.GetInt("Point", totalScore);
        bool BugItem = System.Convert.ToBoolean(PlayerPrefs.GetInt("ExtraSpeed"));
        bool SpeedItem = System.Convert.ToBoolean(PlayerPrefs.GetInt("ExtraBugCount"));
    }
    void SaveData()
    {
        PlayerPrefs.SetInt("Point",totalScore);
        PlayerPrefs.SetInt("ExtraSpeed", System.Convert.ToInt16(speedItem));
        PlayerPrefs.SetInt("ExtraBugCount", System.Convert.ToInt16(bugItem));
    }

}

