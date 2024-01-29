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
    public string shopSceneName;

    private float time;

    public void LoadSceneOnClick()
    {
        AudioManager.instance.SoundPlayOneShot("ButtonClick");
        gameObject.SetActive(true); // Load UI 활성화
        StartCoroutine(LoadScene());
    }
    public void LoadShopSceneOnClick()
    {
        AudioManager.instance.SoundPlayOneShot("ButtonClick");
        gameObject.SetActive(true); // Load UI 활성화
        StartCoroutine(LoadShop());
    }

    IEnumerator LoadScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        operation.allowSceneActivation = false; // 로딩이 완료 되기 전까지는 활성화 되면 안됨

        while(!operation.isDone) // 로딩 완료 여부
        {
            time += Time.deltaTime;
            slider.value = time / 2f;
            if(time > 2)
            {
                operation.allowSceneActivation = true; // 로딩이 완료되면 활성화
            }

            yield return null;
        }
    }
    IEnumerator LoadShop()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(shopSceneName);
        operation.allowSceneActivation = false; // 로딩이 완료 되기 전까지는 활성화 되면 안됨

        while (!operation.isDone) // 로딩 완료 여부
        {
            time += Time.deltaTime;
            slider.value = time / 2f;
            if (time > 2)
            {
                operation.allowSceneActivation = true; // 로딩이 완료되면 활성화
            }

            yield return null;
        }
    }
}


