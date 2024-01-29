using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public string Name;
    public string Description;
    public int ExtraBugCount;
    public float ExtraSpeed;

    public Items(string name, string description, int extraBugCount, float extraSpeed)
    {
        this.Name = name;
        this.Description = description;
        this.ExtraBugCount = extraBugCount;
        this.ExtraSpeed = extraSpeed;
    }
}
