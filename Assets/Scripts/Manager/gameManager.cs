using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
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

    int current = 0;


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
        current++;
        if (current == 3)
        {
            string num = "1";
            StageText.text = num;
        }
        else if (current == 6)
        {
            string num = "2";
            StageText.text = num;
        }
        else if (current == 9)
        {
            string num = "3";
            StageText.text = num;

        }
       
    }  
}

