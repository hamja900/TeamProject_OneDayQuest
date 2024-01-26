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

     void Start()
    {
        StartCoroutine(LodeScene());
    }

    IEnumerator LodeScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        operation.allowSceneActivation = false; 

        while(!operation.isDone) // 로딩 완료 여부
        {
            time += Time.deltaTime;
            slider.value = time / 10f;
            if(time > 10)
            {
                operation.allowSceneActivation = true; // 로딩이 완료되면 활성화
            }

            yield return null;
        }
    }
}


