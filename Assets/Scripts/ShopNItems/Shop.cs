using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text currentPointTxt;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Load();
        }
        catch
        {
            return;
        }
        
    }
    private void Update()
    {
        ShowCurrentPoint();

    }

    void Load()
    {
            PlayerPrefs.GetInt("Point", gameManager.I.totalScore);
            PlayerPrefs.GetInt("ExtraSpeed", gameManager.I.speedItem);
            PlayerPrefs.GetInt("ExtraBugCount", gameManager.I.bugItem);
    }
    void Save()
    {
        PlayerPrefs.SetInt("Point", gameManager.I.totalScore);
        PlayerPrefs.SetInt("ExtraSpeed", gameManager.I.speedItem);
        PlayerPrefs.SetInt("ExtraBugCount", gameManager.I.bugItem);
    }

    void ShowCurrentPoint()
    {
        try
        {
            currentPointTxt.text = gameManager.I.totalScore.ToString();
        }
        catch
        {
            currentPointTxt.text = 0.ToString();
        }
    }


}
