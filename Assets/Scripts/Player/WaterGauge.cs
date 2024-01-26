using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WaterGauge : MonoBehaviour
{
    public Image waterGaugeImage;

    private float maxWater;

    public void ChargeGauge(int current)
    {
        maxWater = gameManager.I.maxcount;
        float water = 0;
        if(current != 0)
        {
            water = current / maxWater;
        }
        waterGaugeImage.rectTransform.localScale = new Vector3(water,1,1);

        if(waterGaugeImage.rectTransform.localScale.x >= 1)
        {
            waterGaugeImage.rectTransform.localScale = new Vector3(0, 1, 1);
        }
    }
}
