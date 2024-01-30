using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text currentPointTxt;
    public GameObject soldOut1;
    public GameObject soldOut2;

    // Start is called before the first frame update
    void Start()
    {
        ShowCurrentPoint();

    }
    private void Update()
    {
        ShowCurrentPoint();
        ShowGoods1();
        ShowGoods2();

    }

    

    void ShowCurrentPoint()
    {
        currentPointTxt.text = gameManager.totalPoint.ToString();
    }

    void ShowGoods1()
    {
        if (gameManager.bugItem)
        {
            soldOut1.SetActive(true);
        }
        else
        {
            soldOut1.SetActive(false);
        }
    }
    void ShowGoods2()
    {
        if(gameManager.speedItem)
        {
            soldOut2.SetActive(true);
        }
        else
        {
            soldOut2.SetActive(false);
        }
    }

}
