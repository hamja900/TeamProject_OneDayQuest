using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WaterGauge : MonoBehaviour
{
    public Image waterGaugeImage;

    private float maxWater;

    public void ChargeGauge()
    {
        maxWater = gameManager.I.maxcount;

        waterGaugeImage.rectTransform.localScale += new Vector3((1/maxWater),0,0);

        if(waterGaugeImage.rectTransform.localScale.x >= 1)
        {
            waterGaugeImage.rectTransform.localScale = new Vector3(0, 1, 1);
        }
    }
}
