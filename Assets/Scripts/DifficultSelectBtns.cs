using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultSelectBtns : MonoBehaviour
{
    public AudioClip click;
    public GameObject difficultyPopUp;

    public void EasyBtn()
    {
        gameManager.I.difficultyType = 0;
        difficultyPopUp.SetActive(false);
        gameManager.I.Easy();
        Time.timeScale = 1;
    }
    public void NormalBtn()
    {
        gameManager.I.difficultyType = 1;
        difficultyPopUp.SetActive(false);
        gameManager.I.Normal();
        Time.timeScale = 1;
    }
    public void HardBtn()
    {
        gameManager.I.difficultyType = 2;
        difficultyPopUp.SetActive(false);
        gameManager.I.Hard();
        Time.timeScale = 1;
    }
}
