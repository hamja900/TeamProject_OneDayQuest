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
        Load();
    }
    private void Update()
    {
        ShowCurrentPoint();

    }

    void Load()
    {
        int total = gameManager.I.totalScore;
        if(total > 0)
        {
            PlayerPrefs.GetInt("Point", gameManager.I.totalScore);
            PlayerPrefs.GetInt("ExtraSpeed", gameManager.I.speedItem);
            PlayerPrefs.GetInt("ExtraBugCount", gameManager.I.bugItem);
        }





    }
    void Save()
    {
        PlayerPrefs.SetInt("Point", gameManager.I.totalScore);
        PlayerPrefs.SetInt("ExtraSpeed", gameManager.I.speedItem);
        PlayerPrefs.SetInt("ExtraBugCount", gameManager.I.bugItem);
    }

    void ShowCurrentPoint()
    {
        int currentPoint = gameManager.I.totalScore;
        currentPointTxt.text = currentPoint.ToString();
    }


}
