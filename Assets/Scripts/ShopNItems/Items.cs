using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public string Name;
    public string Description;
    public int ExtraBugCount;
    public float ExtraSpeed;

    public Image Icon;
    public Text NameTxt;
    public Text DescriptionTxt;

    public ItemSO itemSO;

    public Items(string name, string description, int extraBugCount, float extraSpeed)
    {
        this.Name = name;
        this.Description = description;
        this.ExtraBugCount = extraBugCount;
        this.ExtraSpeed = extraSpeed;
    }

    private void Awake()
    {
        Icon = GetComponentsInChildren<Image>()[1];
        Text[] texts = GetComponentsInChildren<Text>();
        NameTxt = texts[0];
        DescriptionTxt = texts[1];
        NameTxt.text = itemSO.Name;
        DescriptionTxt.text = itemSO.Description;
    }
}
