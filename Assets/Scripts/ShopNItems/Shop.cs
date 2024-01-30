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
        ShowCurrentPoint();

    }
    private void Update()
    {
        ShowCurrentPoint();

    }

    

    void ShowCurrentPoint()
    {
        currentPointTxt.text = gameManager.totalPoint.ToString();
    }


}
