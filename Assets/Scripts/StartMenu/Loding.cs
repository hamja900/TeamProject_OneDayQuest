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

        gameObject.SetActive(true); // Load UI Ȱ��ȭ
        StartCoroutine(LoadScene());
           
       
    }

    IEnumerator LoadScene()
    {
        Debug.Log("ȣ��");
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        operation.allowSceneActivation = false; // �ε��� �Ϸ� �Ǳ� �������� Ȱ��ȭ �Ǹ� �ȵ�

        while(!operation.isDone) // �ε� �Ϸ� ����
        {
            time += Time.deltaTime;
            slider.value = time / 2f;
            if(time > 2)
            {
                operation.allowSceneActivation = true; // �ε��� �Ϸ�Ǹ� Ȱ��ȭ
            }

            yield return null;
        }


    }
}


