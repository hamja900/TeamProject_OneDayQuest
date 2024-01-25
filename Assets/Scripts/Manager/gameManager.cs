using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public GameObject rain;
    public RainDrops raindrops;
    public DropSO dropSO;
    public DropSO highDropSO;
    public DropSO bugSO;
    public GameObject rainSpawnPosition;
    public Text StageText; // 당근 성장단계 텍스트

    private int current = 0;
    private int stage = 1;
    private int maxcount = 0;

    void Awake()
    {
        I = this;
        raindrops = rain.GetComponent<RainDrops>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartDrop", 0, 0.5f);
        InvokeRepeating("HighStartDrop", 2f, 0.8f);
        InvokeRepeating("BugStart", 1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartDrop()
    {
        float x = UnityEngine.Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
        DropManager.instance.DropFromSky(transform.position, dropSO);
    }
    public void HighStartDrop()
    {
        float x = UnityEngine.Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
        DropManager.instance.DropFromSky(transform.position, highDropSO);
    }
    public void BugStart()
    {
        float x = UnityEngine.Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
        DropManager.instance.DropFromSky(transform.position, bugSO);


    }


    public void GrowthCarrot() //물방울 모으면 단계 상승
    {
        maxcount = stage * 3;
        current++;
        
       
        if (current == maxcount)
        {
            StageText.text = stage.ToString();
            stage++;
            current = 0;
        }

        if (stage > 3)
        {
            stage = 1;
        }
    }  
}

