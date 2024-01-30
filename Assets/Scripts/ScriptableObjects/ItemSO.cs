using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData",menuName ="ItemSetting/Items")]
public class ItemSO : ScriptableObject
{
    public int ItemId;
    public string Name;
    [TextArea]
    public string Description;
    public int Price;
    public int ExtraBugCount;
    public float ExtraSpeed;
    public Sprite ItemIcon;
}
