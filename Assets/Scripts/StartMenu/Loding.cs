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
        gameObject.SetActive(true); // ���� ������Ʈ Ȱ��ȭ
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        operation.allowSceneActivation = false; 

        while(!operation.isDone) // �ε� �Ϸ� ����
        {
            time += Time.deltaTime;
            slider.value = time / 3f;
            if(time > 3)
            {
                operation.allowSceneActivation = true; // �ε��� �Ϸ�Ǹ� Ȱ��ȭ
            }

            yield return null;
        }
    }
}


