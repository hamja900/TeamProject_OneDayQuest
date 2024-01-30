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
        bool bugItem = System.Convert.ToBoolean(PlayerPrefs.GetInt("ExtraBugCount"));
        bool speedItem = System.Convert.ToBoolean(PlayerPrefs.GetInt("ExtraSpeed"));
    }
    void Save()
    {
        PlayerPrefs.SetInt("Point", gameManager.I.totalScore);
        PlayerPrefs.SetInt("ExtraSpeed", System.Convert.ToInt16(gameManager.I.speedItem));
        PlayerPrefs.SetInt("ExtraBugCount", System.Convert.ToInt16(gameManager.I.bugItem));
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
