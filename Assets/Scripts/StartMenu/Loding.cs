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

        while(!operation.isDone) // �ε� �Ϸ� ����
        {
            time += Time.deltaTime;
            slider.value = time / 10f;
            if(time > 10)
            {
                operation.allowSceneActivation = true; // �ε��� �Ϸ�Ǹ� Ȱ��ȭ
            }

            yield return null;
        }
    }
}


