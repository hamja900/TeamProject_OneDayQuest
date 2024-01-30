using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseBtn : MonoBehaviour
{
    public void OnClickPurchasePesticide()
    {
        int currentPoint = gameManager.totalPoint;
        bool havePesticede = gameManager.bugItem;
        if (currentPoint >= 50 && havePesticede == false)
        {
            currentPoint -= 50;
            gameManager.totalPoint = currentPoint;
            havePesticede = true;
            gameManager.bugItem = true;
        }

    }

    public void OnClickPurchseBoots()
    { 
       
        int currentPoint = gameManager.totalPoint;
        bool haveBoots = gameManager.speedItem;
        if (currentPoint >= 100 && haveBoots == false)
        {
            currentPoint -= 100;
            gameManager.totalPoint = currentPoint;
            haveBoots = true;
            gameManager.speedItem = true;
        }

    }
}
