using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseBtn : MonoBehaviour
{
    public void OnClickPurchasePesticide()
    {
        try
        {
            int currentPoint = gameManager.I.totalScore;
            bool havePesticede = gameManager.I.bugItem;
            if (currentPoint >= 50 && havePesticede==false)
            {
                currentPoint -= 50;
                havePesticede=true;
            }
        }
        catch
        {
            return;
        }

    }

    public void OnClickPurchseBoots()
    {
        try
        {
            int currentPoint = gameManager.I.totalScore;
            bool haveBoots = gameManager.I.speedItem;
            if(currentPoint >=100  && haveBoots == false)
            {
                currentPoint -= 100;
                haveBoots=true;
            }
        }
        catch
        {
            return;
        }

    }
}
