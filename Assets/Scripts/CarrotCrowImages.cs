using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarrotCrowImages : MonoBehaviour
{
    public UnityEngine.UI.Image carrotgrow;

    public Sprite carrot0;
    public Sprite carrot1;
    public Sprite carrot2;
    public void CarrotImage()
    {
        if(gameManager.I.stage == 1)
        {
            carrotgrow.sprite = carrot0;
        }
        else if (gameManager.I.stage == 2)
        {
            carrotgrow.sprite=carrot1;
        }
        else if (gameManager.I.stage == 3)
        {
            carrotgrow.sprite = carrot2;
        }
    }
}
