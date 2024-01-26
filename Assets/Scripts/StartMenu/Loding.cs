using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loding : MonoBehaviour
{

    public Slider slider;
    public string SceneName;

    private float time;

    public void LoadSceneOnClick()
    {
        gameObject.SetActive(true); // 게임 오브젝트 활성화
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        operation.allowSceneActivation = false; 

        while(!operation.isDone) // 로딩 완료 여부
        {
            time += Time.deltaTime;
            slider.value = time / 3f;
            if(time > 3)
            {
                operation.allowSceneActivation = true; // 로딩이 완료되면 활성화
            }

            yield return null;
        }
    }
}


