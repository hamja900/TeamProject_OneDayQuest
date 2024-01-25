using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBtn : MonoBehaviour
{
    public GameObject panel;

    public void OnClickClose()
    {
        panel.SetActive(false);
    }
}
