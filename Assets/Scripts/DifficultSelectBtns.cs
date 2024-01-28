using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultSelectBtns : MonoBehaviour
{
    public AudioClip click;
    public GameObject difficultyPopUp;

    public GameObject panel;
    public Text panelTxt;

    public void EasyBtn()
    {
        gameManager.I.maxCarrot = 3;
        gameManager.I.difficultyType = 0;
        panelTxt.text = gameManager.I.maxCarrot.ToString();
        difficultyPopUp.SetActive(false);
        panel.SetActive(true);
        gameManager.I.Easy();
        //Time.timeScale = 1;
        
        
    }
    public void NormalBtn()
    {
        gameManager.I.maxCarrot = 5;
        gameManager.I.difficultyType = 1;
        panelTxt.text = gameManager.I.maxCarrot.ToString();
        difficultyPopUp.SetActive(false);
        panel.SetActive(true);
        gameManager.I.Normal();
        //Time.timeScale = 1;
    }
    public void HardBtn()
    {
        gameManager.I.maxCarrot = 8;
        gameManager.I.difficultyType = 2;
        panelTxt.text = gameManager.I.maxCarrot.ToString();
        difficultyPopUp.SetActive(false);
        panel.SetActive(true);
        gameManager.I.Hard();
        //Time.timeScale = 1;
    }

    public void OnClickContinue()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
