using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text currentPointTxt;
    

    // Start is called before the first frame update
    void Start()
    {
        Load();
    }
    private void Update()
    {
        Save();
        ShowCurrentPoint();
    }

    void Load()
    {
        if (gameManager.I.point == 0)
            return;
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
        currentPointTxt.text = gameManager.I.totalScore.ToString();
    }


}
